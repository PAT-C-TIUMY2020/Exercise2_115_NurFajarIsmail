using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceRest_115_NurFajarIsmail
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
		[OperationContract]
		[WebGet(UriTemplate = "Mahasiswa",  ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
		List<Mahasiswa> GetAllMahasiswa();
		[OperationContract]
       
		[WebInvoke(Method = "PUT",UriTemplate = "Mahasiswaedit", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		string EditMahasiswa(string nim, string nama, string prodi, string angkatan);
		[OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "deleteMahasiswa", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
		string DeleteMahasiswa(string nim);
		[OperationContract]
		[WebInvoke( UriTemplate = "jumlahMahasiswa", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
		string CountMahasiswa();
		// TODO: Add your service operations here
	}

    [DataContract]

    public class Mahasiswa
    {

		private string _nama, _nim, _prodi, _angkatan;
		[DataMember(Order = 1)]
		public string nama
		{
			get { return _nama; }
			set { _nama = value; }
		}

		[DataMember(Order = 2)]
		public string nim
		{
			get { return _nim; }
			set { _nim = value; }
		}

		[DataMember(Order = 3)]
		public string prodi
		{
			get { return _prodi; }
			set { _prodi = value; }
		}

		[DataMember(Order = 4)]
		public string angkatan
		{
			get { return _angkatan; }
			set { _angkatan = value; }
		}
	}

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ServiceRest_115_NurFajarIsmail.ContractType".

}
