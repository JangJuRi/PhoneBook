using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_test
{
    public partial class numberMain : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)dataGridView1.DataSource).GetChanges();
            if(changes!=null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                mySqlDataAdapter.Update(changes);
                ((DataTable)dataGridView1.DataSource).AcceptChanges();
            }
        }

        numberLoading loadingForm;
        public int count = 0;
        public int rowNum = 0;
        public int EditRowNum = 0;
        public string dataEditName;
        public string dataEditNumber;
        public string deleteText;
        public int Totalnumber;

        /* 데이터 편집 변수 */
        public string name;
        public string number;
        public string job;
        public string email;
        public string memo;

        public numberMain()
        {
            InitializeComponent();
        }

        public numberMain(numberLoading loading_form)
        {
            InitializeComponent();
            loadingForm = loading_form;
        }

        /* select 틀 */
        private void selectTool(string tool)
        {
            string strConn = "Server=localhost;Database=phone;Uid=root;Pwd=1234;";
            connection = new MySqlConnection(strConn);

            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter(tool, connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                this.CloseConnection();
            }
        }

        /* insert/update 틀 */
        public void insert_updateTool(string tool)
        {
            connection.Open();
            String sql = tool;
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /* 데이터 불러오기 */
        public void dataLoad()
        {
            selectTool("select name as 이름,phone_num as 번호,job as 직업,email as 이메일, memo as 메모,saveDate as 통화날짜, callNum as 전화횟수 from add_user");
            Totalnumber = int.Parse(dataGridView1.Rows.Count + ""); totalNumberText.Text = Totalnumber + "";
        }

        private void numberMain_Load(object sender, EventArgs e)
        {   numberMain mainForm = new numberMain();
            mainForm.StartPosition = FormStartPosition.Manual;
            mainForm.Location = new Point(this.Location.X,this.Location.Y);

            Totalnumber = int.Parse(dataGridView1.Rows.Count + ""); totalNumberText.Text = Totalnumber + "";

            dataLoad();
            phone_num();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            numberAdd addForm = new numberAdd(this);
            addForm.StartPosition = FormStartPosition.Manual;
            addForm.Location = new Point(this.Location.X, this.Location.Y);
            

            addForm.Shown += (sf, se) => { this.Hide(); };
            addForm.FormClosing += (sf, se) => { this.Show(); };
            addForm.Show();
        }

        /* 연락처 편집 */
        private void editButton_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                numberEdit editForm = new numberEdit(this);
                editForm.StartPosition = FormStartPosition.Manual;
                editForm.Location = new Point(this.Location.X, this.Location.Y);

                /* 해당 연락처 정보 로드 */
                name = dataGridView1["이름", EditRowNum].Value.ToString();
                number = dataGridView1["번호", EditRowNum].Value.ToString();
                job = dataGridView1["직업", EditRowNum].Value.ToString();
                email = dataGridView1["이메일", EditRowNum].Value.ToString();
                memo = dataGridView1["메모", EditRowNum].Value.ToString();

                editForm.Shown += (sf, se) => { this.Hide(); };
                editForm.FormClosing += (sf, se) => { this.Show(); };
                editForm.Show();
            }
            else MessageBox.Show("편집할 연락처가 없습니다!", "편집 불가", MessageBoxButtons.OK);
        }

        
        public void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditRowNum = e.RowIndex;
            deleteText = dataGridView1["이름", e.RowIndex].Value.ToString(); //연락처 삭제
            Nownum();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            deleteText = dataGridView1["이름", e.RowIndex].Value.ToString();
            EditRowNum = e.RowIndex;
        }

        /* 연락처 삭제 */
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (count != 0)
                {
                    insert_updateTool("delete from add_user where name ='" + deleteText + "'");
                    dataLoad();
                    count--;
                    datacountText.Text = count + "";
                    progressBar1.Value--;
                    Totalnumber = int.Parse(dataGridView1.Rows.Count + ""); totalNumberText.Text = Totalnumber + "";
                }
                else MessageBox.Show("삭제할 연락처가 없습니다!", "삭제 불가", MessageBoxButtons.OK);
            }
            catch { MessageBox.Show("삭제할 연락처가 없습니다!", "삭제 불가", MessageBoxButtons.OK); }
        }

        /* 전화 걸기 */
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                insert_updateTool("update add_user set callNum = callNum+1 where name = '" + dataGridView1["이름", e.RowIndex].Value.ToString() + "'");
                insert_updateTool("update add_user set saveDate ='"+ DateTime.Now.ToString("yyyyMMdd")+ "' where name = '" + dataGridView1["이름", e.RowIndex].Value.ToString() + "'");
                dataLoad();
                MessageBox.Show("전화를 걸었습니다!", "전화", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { MessageBox.Show("전화 할 목록을 더블클릭해주세요!"); }
        }


        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch(MySqlException ex) { return false; }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch(MySqlException ex) { return false; }
        }

        /* 새로고침 */
        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataLoad();
            phone_num();
        }

        /* 전화번호 개수 */
        public void phone_num()
        {
            count = int.Parse(dataGridView1.RowCount.ToString());
            datacountText.Text = count + "";
            progressBar1.Value = count;
        }

        /* 검색하기 */
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) MessageBox.Show("검색 결과가 없습니다!");
            else if (searchText.Text == "") MessageBox.Show("문자를 입력해주세요!");
            else
            {
                selectTool("select name as 이름,phone_num as 번호,job as 직업,email as 이메일, memo as 메모,saveDate as 통화날짜, callNum as 전화횟수 from add_user where name like '%" + searchText.Text + "%'or phone_num like '%" + searchText.Text + "%'or job like '%" + searchText.Text + "%'or email like '%" + searchText.Text + "%'");
                searchText.Text = "";
            }
        }

        /* 안쓰는 번호 */
        private void worstNumButton_Click(object sender, EventArgs e)
        {
            selectTool("select name as 이름,phone_num as 번호,job as 직업,email as 이메일, memo as 메모,saveDate as 통화날짜, callNum as 전화횟수 from add_user where callNum<1");
            Totalnumber = int.Parse(dataGridView1.Rows.Count + ""); totalNumberText.Text = Totalnumber + "";
            nowNumberText.Text = "0";
        }

        /* 많이 쓰는 번호 */
        private void bestNumButton_Click(object sender, EventArgs e)
        {
            selectTool("select name as 이름,phone_num as 번호,job as 직업,email as 이메일, memo as 메모,saveDate as 통화날짜, callNum as 전화횟수 from add_user where callNum>=1 order by callNum desc limit 10");
            Totalnumber = int.Parse(dataGridView1.Rows.Count + ""); totalNumberText.Text = Totalnumber + "";
            nowNumberText.Text = "0";
        }

        /* 1년 전 연락처 */
        private void oldNumButton_Click(object sender, EventArgs e)
        {
            DateTime Today = DateTime.Now;
            string TimeGap = (DateTime.Today.AddYears(-1)).ToString("yyyyMMdd");
            selectTool("select name as 이름,phone_num as 번호,job as 직업,email as 이메일, memo as 메모,saveDate as 통화날짜, callNum as 전화횟수 from add_user where saveDate<=" + TimeGap);
            Totalnumber = int.Parse(dataGridView1.Rows.Count + ""); totalNumberText.Text = Totalnumber + "";
            nowNumberText.Text = "0";
        }


        /* 현재 위치 */
        private void Nownum()
        {
            int Nownumber = int.Parse(EditRowNum + "") + 1;
            nowNumberText.Text = Nownumber + "";          
        }
    }
}
