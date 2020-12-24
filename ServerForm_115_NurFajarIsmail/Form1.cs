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
            label1.Text = "Server OFF";
            label2.Text = "Klik ON untuk menyalakan Server";
            btOff.Enabled = false;
            
            
            

            

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
                label2.Text = "Klik OFF untuk mematikan Server";
                btOff.Enabled = true;

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
                btON.Enabled = false;
                label3.Text = "Server hanya bisa dinyalakan sekali";
                label4.Text = "Silahkan Cloase Server dan Run lagi";

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
