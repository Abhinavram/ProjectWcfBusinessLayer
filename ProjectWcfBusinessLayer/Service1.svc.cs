using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProjectWcfBusinessLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        ProjectDBEntities db = new ProjectDBEntities();

        public List<Employee> GetAllEmployees()
        {
            return db.Employees.ToList();
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customerlist = new List<Customer>();
            var listuser = from k in db.Customers select k;
            foreach (var item in listuser)
            {
                Customer cust = new Customer();
                cust.CustomerId = item.CustomerId;
                cust.CustorName = item.CustorName;
                cust.Address = item.Address;
                customerlist.Add(cust);
            }
            return customerlist;
        }

        public int DeleteUserById(int CustomerId)
        {
            Customer cust = new Customer();
            cust.CustomerId = CustomerId;
            db.Entry(cust).State = System.Data.Entity.EntityState.Deleted;
            int Retval = db.SaveChanges();
            return Retval;
        }

    }
}
