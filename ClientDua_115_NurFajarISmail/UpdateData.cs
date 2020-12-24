using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDua_115_NurFajarISmail
{
    public partial class UpdateData : Form
    {
        public UpdateData()
        {
            InitializeComponent();
            textBoxNIM.Text = Homepage.sendtext;
            textBoxNIM.Enabled = false;

        }

        private void UpdateData_Load(object sender, EventArgs e)
        {

        }

        private void btKembali_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            this.Hide();
            home.Show();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            this.Hide();
            home.Show();
        }
    }
}
