using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_test
{
    public partial class numberAdd : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=phone;Uid=root;Pwd=1234;");

        numberMain mainForm;
        public numberAdd()
        {
            InitializeComponent();
        }

        public numberAdd(numberMain main_Form)
        {
            InitializeComponent();
            mainForm = main_Form;
        }

        private void addDeleteButton_Click(object sender, EventArgs e)
        {
            addNameTextbox.Text = "";
            addNumberTextbox.Text = "";
            addJobTextbox.Text = "";
            addEmailTextbox.Text = "";
            addMemoTextbox.Text = "";
        }

        public void addAddButton_Click(object sender, EventArgs e)
        {
            int number = 0;

            /* DB에 연락처 저장 */
            if (mainForm.count < 100)
            {
                string date = DateTime.Now.ToString("yyyyMMdd");
                string addNumText = addNumberTextbox.Text;
                //int callnum = 0;
                try
                {
                    if (addNameTextbox.Text == "") MessageBox.Show("이름을 입력해주세요!");

                    else if (int.TryParse(addNumberTextbox.Text, out number) == true)
                    {
                        conn.Open();
                        if (addNumText.Substring(0, 1) == "0")
                        {
                         String sql = "INSERT INTO add_user(name,phone_num,job,email,memo)" + "VALUES ('" + addNameTextbox.Text + "','" + "0"+number.ToString() + "','" + addJobTextbox.Text + "','" + addEmailTextbox.Text + "','" + addMemoTextbox.Text + "')";    
                         MySqlCommand cmd = new MySqlCommand(sql, conn);
                         cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            String sql = "INSERT INTO add_user(name,phone_num,job,email,memo)" + "VALUES ('" + addNameTextbox.Text + "','" + number.ToString() + "','" + addJobTextbox.Text + "','" + addEmailTextbox.Text + "','" + addMemoTextbox.Text + "')";
                            MySqlCommand cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();                      
                        mainForm.dataLoad();
                        mainForm.phone_num();
                    }
                    else MessageBox.Show("전화번호는 숫자로 입력해주세요!");
                }
                catch { MessageBox.Show("같은 데이터가 존재하거나 문자를 잘못 입력하셨어요!"); }
            }
            else { MessageBox.Show("전화번호부가 가득 찼어요!"); }
            this.Close();
        }
    }
}
