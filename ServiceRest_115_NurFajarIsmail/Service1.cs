using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceRest_115_NurFajarIsmail
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string CountMahasiswa()
        {
            string msg = "gagal";
            SqlConnection sqlcon = new SqlConnection("Data Source = DESKTOP-47CL7NM; Initial Catalog =\"TI UMY\"; Persist Security Info = True; User ID =sa; Password =Fismljr10");
            string query = String.Format("select Count(NIM) From Mahasiswa");
           
            SqlCommand sqlcom = new SqlCommand(query, sqlcon);

            try
            {
                sqlcon.Open();
                Console.WriteLine(query);
                Int32 count = (Int32)sqlcom.ExecuteScalar();
                sqlcon.Close();
                msg = "Jumlah Data " + count;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(query);
                msg = "GAGAL";
            }

            return msg;
        }

        public string EditMahasiswa(string nim, string nama, string prodi, string angkatan)
        {
            string msg = "GAGAL";
            SqlConnection sqlcon = new SqlConnection("Data Source = DESKTOP-47CL7NM; Initial Catalog =\"TI UMY\"; Persist Security Info = True; User ID =sa; Password =Fismljr10");
            string query = String.Format("update Mahasiswa set nama = '{1}',prodi='{2}', angkatan='{3}' where nim='{0}'", nim, nama, prodi, angkatan);
            SqlCommand sqlcom = new SqlCommand(query, sqlcon);
            try
            {
                sqlcon.Open();
                Console.WriteLine(query);
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();
                msg = "Sukses";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(query);
                msg = "GAGAL";
            }


            return msg;
        }

        public List<Mahasiswa> GetAllMahasiswa()
        {
            List<Mahasiswa> mahas = new List<Mahasiswa>();
           
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-47CL7NM; Initial Catalog =\"TI UMY\"; Persist Security Info = True; User ID =sa; Password =Fismljr10");
            string query = "select Nama, NIM, Prodi, Angkatan from Mahasiswa";
            SqlCommand com = new SqlCommand(query, con); //yang dikirim ke sql

            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader(); //mendapatkan data yang telah dieksekusi, dari select, hasil query ditaro direader

                while (reader.Read())
                {
                    Mahasiswa mhs = new Mahasiswa();
                    mhs.nama = reader.GetString(0); //0 itu array pertama diambil dari iservice
                    mhs.nim = reader.GetString(1);
                    mhs.prodi = reader.GetString(2);
                    mhs.angkatan = reader.GetString(3);

                    mahas.Add(mhs);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(query);
            }
            return mahas;
        }

      





        string IService1.DeleteMahasiswa(string nim)
        {
            string msg = "GAGAL";

            Mahasiswa mhs = new Mahasiswa();
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-47CL7NM; Initial Catalog =\"TI UMY\"; Persist Security Info = True; User ID =sa; Password =Fismljr10");
            string query = String.Format("delete from Mahasiswa where NIM = '{0}'", nim);
            SqlCommand com = new SqlCommand(query, con);

            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();

                con.Close();
                msg = "Sukses";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(query);
                msg = "GAGAL";
            }
            return msg;
        }

       
    }
}
