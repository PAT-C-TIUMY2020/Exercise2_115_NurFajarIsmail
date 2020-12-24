using Newtonsoft.Json;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDua_115_NurFajarISmail
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
			TampilData();
			JumlahData();

		}
		public class Mahasiswa
		{
			private string _nama, _nim, _prodi, _angkatan;
			public string nama
			{
				get { return _nama; }
				set { _nama = value; }
			}

			public string nim
			{
				get { return _nim; }
				set { _nim = value; }
			}

			public string prodi
			{
				get { return _prodi; }
				set { _prodi = value; }
			}

			public string angkatan
			{
				get { return _angkatan; }
				set { _angkatan = value; }
			}
		}
		

		public void TampilData()
        {
            var json = new WebClient().DownloadString("http://localhost:1926/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

			dataGridView1.DataSource = data;

        }
		public void JumlahData()
        {
			var json = new WebClient().DownloadString("http://localhost:1926/Mahasiswa");
			var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
			int length = data.Count();
			labelJumlah.Text = length.ToString();

		}

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
		string baseurl = "http://localhost:1926";
		private void btDelete_Click(object sender, EventArgs e)
        {


			if (MessageBox.Show("Are you sure you want to delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					ClassMahasiswa classData = new ClassMahasiswa();
					classData.deleteMahasiswa(textBoxNIM.Text);

					
					MessageBox.Show("Data successfuly deleted");
					Homepage home = new Homepage();
					this.Hide();
					home.Show();
				}
				catch (Exception ex)
				{
					
				}
			}


		}
		public static string sendtext = "";
		private void btUpdate_Click(object sender, EventArgs e)
        {
			
			if (textBoxNIM.Text == "")
            {
				MessageBox.Show("NIM harus diisi dulu");
            }
			else
            {
				sendtext = textBoxNIM.Text;
				UpdateData update = new UpdateData();
				this.Hide();
				update.Show();
			}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
