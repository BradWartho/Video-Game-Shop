using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    {
        string CustomerId = "1";
        string Forename = "George";
        string Surname = "Mintoft";
        string Address = "1 A Street";
        string County = "A County";
        string PostCode = "AB1 2CD";
        string EmailAddress = "george@gmail.com";
        string PhoneNumber = "01234566789";

        [TestMethod]
        //ensures the class is present
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ForenamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            ACustomer.Forename = Forename;
            Assert.AreEqual(ACustomer.Forename, Forename);
        }
        [TestMethod]
        public void SurnamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            ACustomer.Surname = Surname;
            Assert.AreEqual(ACustomer.Surname, Surname);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            ACustomer.Address = Address;
            Assert.AreEqual(ACustomer.Address, Address);
        }

        [TestMethod]
        public void CountyPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            ACustomer.County = County;
            Assert.AreEqual(ACustomer.County, County);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            ACustomer.PostCode = PostCode;
            Assert.AreEqual(ACustomer.PostCode, PostCode);
        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            ACustomer.EmailAddress = EmailAddress;
            Assert.AreEqual(ACustomer.EmailAddress, EmailAddress);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            ACustomer.PhoneNumber = PhoneNumber;
            Assert.AreEqual(ACustomer.PhoneNumber, PhoneNumber);
        }
    }
}
