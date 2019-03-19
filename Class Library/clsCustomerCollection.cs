using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class clsCustomerCollection
    {
        //private list of all customers
        private List<clsCustomer> mAllCustomers = new List<clsCustomer>();
        //public count
        public int Count
        {
            get
            {
                return mAllCustomers.Count;
            }
            set
            {

            }
        }

        //public list of all customers
        public List<clsCustomer> AllCustomers
        {
            get
            {
                return mAllCustomers;
            }
            set
            {
                mAllCustomers = value;
            }
        }

        //public constructor for collection class
        public clsCustomerCollection()
        {
            //creates an instance to store a customer
            clsCustomer ACustomer = new clsCustomer();
            //adds forename
            ACustomer.Forename = "George";
            mAllCustomers.Add(ACustomer);
            //adds surname
            ACustomer = new clsCustomer();
            ACustomer.Surname = "Mintoft";
            mAllCustomers.Add(ACustomer);
            //adds address
            ACustomer = new clsCustomer();
            ACustomer.Address = "1 A Streer";
            mAllCustomers.Add(ACustomer);
            //adds county
            ACustomer = new clsCustomer();
            ACustomer.County= "A County";
            mAllCustomers.Add(ACustomer);
            //adds post code
            ACustomer = new clsCustomer();
            ACustomer.PostCode= "AB1 1CD";
            mAllCustomers.Add(ACustomer);
            //adds email address
            ACustomer = new clsCustomer();
            ACustomer.EmailAddress= "geroge@gmail.com";
            mAllCustomers.Add(ACustomer);
            //adds phone number
            ACustomer = new clsCustomer();
            ACustomer.PhoneNumber= "01234567890";
            mAllCustomers.Add(ACustomer);
        }
    }
}
