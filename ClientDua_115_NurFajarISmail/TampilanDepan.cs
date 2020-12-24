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
    public partial class TampilanDepan : Form
    {
        public TampilanDepan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            this.Hide();
            home.Show();
        }
    }
}
