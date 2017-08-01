using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProjectWcfBusinessLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<Employee> GetAllEmployees();

        [OperationContract]
        List<Customer> GetAllCustomers();

        [OperationContract]
        int DeleteUserById(int CustomerId);

        [OperationContract]
        int AddCustomer(int CustomerId, string CustorName, string Address);

        [OperationContract]
        int UpdateCustomer(int CustomerId, string CustorName, string Address);
    }

        [DataContract]
        public class Customers
        {
            [DataMember]
            public int CustomerId { get; set; }
            [DataMember]
            public string CustorName { get; set; }
            [DataMember]
            public string Address { get; set; }
        }
        

        // TODO: Add your service operations here
}
