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
    public partial class numberLoading : Form
    {
        public numberLoading()
        {
            InitializeComponent();
        }

        private void numberLoading_Load(object sender, EventArgs e)
        {
            numberLoading loadingForm = new numberLoading();
            loadingForm.StartPosition = FormStartPosition.Manual;
            loadingForm.Location = new Point(this.Location.X, this.Location.Y);
        }

        private void GoMainButton_Click(object sender, EventArgs e)
        {
            numberMain mainForm = new numberMain(this);
            mainForm.StartPosition = FormStartPosition.Manual;
            mainForm.Location = new Point(this.Location.X, this.Location.Y);


            mainForm.Shown += (sf, se) => { this.Hide(); };
            mainForm.FormClosing += (sf, se) => { this.Show(); };
            mainForm.Show();
        }
    }
}
