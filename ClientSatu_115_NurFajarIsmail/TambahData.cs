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

namespace ClientSatu_115_NurFajarIsmail
{
    public partial class TambahData : Form
    {

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
		string baseUrl = "http://localhost:1907/";

		public TambahData()
        {
            InitializeComponent();
			
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
			Mahasiswa mhs = new Mahasiswa();
			mhs.nama = textBoxNama.Text;
            mhs.nim = textBoxNIM.Text;
            mhs.prodi= textBoxProdi.Text;
            mhs.angkatan = comboBoxAngkatan.Text;


            var data = JsonConvert.SerializeObject(mhs);
            var postdata = new WebClient();
            postdata.Headers.Add(HttpRequestHeader.ContentType, "application/json");
			string response = postdata.UploadString(baseUrl + "Mahasiswa", data);

			MessageBox.Show(response);
			MessageBox.Show("Silahkan Sinkronisasi di Homepage3B pada ClietDua");

			Homepage hm = new Homepage();
			this.Hide();
			hm.Show();
        }

        private void TambahData_Load(object sender, EventArgs e)
        {

        }
    }
}
