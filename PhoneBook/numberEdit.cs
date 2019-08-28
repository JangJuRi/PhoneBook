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
    public partial class numberEdit : Form
    {
        numberMain mainForm;
        public numberEdit()
        {
            InitializeComponent();
        }
        public numberEdit(numberMain main_Form)
        {
            InitializeComponent();
            mainForm = main_Form;
        }

        private void editDeleteButton_Click(object sender, EventArgs e)
        {
            editNameTextbox.Text = "";
            editNumTextbox.Text = "";
            editJobTextbox.Text = "";
            editEmailTextbox.Text = "";
            editMemoTextbox.Text = "";
        }

        private void numberEdit_Load(object sender, EventArgs e)
        {
            editNameTextbox.Text = mainForm.name;
            editNumTextbox.Text = mainForm.number;
            editJobTextbox.Text = mainForm.job;
            editEmailTextbox.Text = mainForm.email;
            editMemoTextbox.Text = mainForm.memo;
        }

        public void editAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (editNameTextbox.Text != "" && editNumTextbox.Text!="")
                {
                    mainForm.insert_updateTool("update add_user set name ='" + editNameTextbox.Text + "',phone_num ='" + editNumTextbox.Text + "',job ='" + editJobTextbox.Text + "',email='" + editEmailTextbox.Text + "',memo='" + editMemoTextbox.Text + "'where name ='" + mainForm.name + "'");
                    mainForm.dataLoad();
                    MessageBox.Show("수정 완료!");
                }
                else if (editNameTextbox.Text=="")
                {
                    MessageBox.Show("이름을 입력해주세요!");
                }
               else if(editNumTextbox.Text=="")
                {
                    MessageBox.Show("전화번호를 입력해주세요!");
                }
            }
            catch
            {
                MessageBox.Show("연락처 변경 실패 - 정보를 정확히 입력해주세요!");
            }
            this.Close();
        }
    }
}
