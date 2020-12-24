using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClientSatu_115_NurFajarIsmail.TambahData;

namespace ClientSatu_115_NurFajarIsmail
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            TampilData();
        }

        private void btTambahData_Click(object sender, EventArgs e)
        {
            TambahData td =  new TambahData();
            this.Hide();
            td.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        public void TampilData()
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

            dataGridView1.DataSource = data;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCari_Click(object sender, EventArgs e)
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
            string nim = textBoxNIM.Text;
            if (nim == null || nim == "")
            {
                dataGridView1.DataSource = data;
            }
            else
            {
                var item = data.Where(x => x.nim == textBoxNIM.Text).ToList();

                dataGridView1.DataSource = item;
            }
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
