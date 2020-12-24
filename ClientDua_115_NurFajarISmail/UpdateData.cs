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

            if (textBoxNIM.Text != "" &&
                textBoxNama.Text != "" &&
                textBoxProdi.Text != "" &&
                textBoxAngkatan.Text != "")
            {
                if (textBoxNIM.Text.Length <= 12 &&
                textBoxAngkatan.Text.Length <= 4 &&
                textBoxProdi.Text.Length <= 30 &&
                textBoxNama.Text.Length <= 20)
                {
                    try
                    {
                        Mahasiswa mhs = new Mahasiswa();
                        mhs.nim = textBoxNIM.Text;
                        mhs.nama = textBoxNama.Text;
                        mhs.prodi = textBoxProdi.Text;
                        mhs.angkatan = textBoxAngkatan.Text;

                        ClassMahasiswa classData = new ClassMahasiswa();
                        classData.updateDatabase(mhs);
                        MessageBox.Show("Data successfuly updated");
                      
                        
                    }
                    catch (Exception ex)
                    {
                       
                    }
                }
                else
                {
                    MessageBox.Show("Please check your data");
                }
            }
            else
            {
                MessageBox.Show("Please check your data");
            }
            Homepage home = new Homepage();
            this.Hide();
            home.Show();
        }
    }
}
