using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    
    [TestClass]
    public class tstCustomerCollection
    {
        //Creates a customer to test data against
        private void CreateTestList()
        {
            
        }

        [TestMethod]
        public void InstanctOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        //ensures the count function is working
        public void CountCustomersOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            int Count = 7;
            AllCustomers.Count = Count;

            Assert.AreEqual(AllCustomers.Count, Count);
        }
        [TestMethod]
        public void AllCustomersOK()
        {
            clsCustomerCollection Customers = new clsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.CustomerId = 1;
            TestItem.Forename = "George";
            TestItem.Surname = "Mintoft";
            TestItem.Address = "1 A Street";
            TestItem.County = "A County";
            TestItem.PostCode = "AB1 2CD";
            TestItem.EmailAddress = "george@gmail.com";
            TestItem.PhoneNumber = "0123456789";

            TestList.Add(TestItem);

            Customers.AllCustomers = TestList;

            Assert.AreEqual(Customers.AllCustomers, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            clsCustomerCollection Customers = new clsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.CustomerId = 1;
            TestItem.Forename = "George";
            TestItem.Surname = "Mintoft";
            TestItem.Address = "1 A Street";
            TestItem.County = "A County";
            TestItem.PostCode = "AB1 2CD";
            TestItem.EmailAddress = "george@gmail.com";
            TestItem.PhoneNumber = "0123456789";

            TestList.Add(TestItem);

            Customers.AllCustomers = TestList;

            Assert.AreEqual(Customers.Count, TestList.Count);
        }
        [TestMethod]
        public void SevenEntriesPresent()
        {
            clsCustomerCollection Customers = new clsCustomerCollection();

            Assert.AreEqual(Customers.Count, 7);
        }
    }
}
