using ServiceRest_115_NurFajarIsmail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerForm_115_NurFajarIsmail
{
    public partial class Form1 : Form
    {
        ServiceHost hostObjek = null;
        public Form1()
        {
            InitializeComponent();
            
            
            

            

        }
       



        

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void btON_Click(object sender, EventArgs e)
        {
            try
            {
                hostObjek = new ServiceHost(typeof(Service1));
                hostObjek.Open();
                label1.Text = "Server ON";

            }
            catch (Exception ex)
            {
                hostObjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private void btOff_Click(object sender, EventArgs e)
        {
            try
            {
                hostObjek = new ServiceHost(typeof(Service1));
                hostObjek.Close();
                label1.Text = "Server OFF";

            }
            catch (Exception ex)
            {
                hostObjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
    }
}
