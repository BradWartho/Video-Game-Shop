using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstStaff
    {

        string FirstName = "Dave";
        string LastName = "Peters";
        string StaffID = "123";
        string Address = "Gateway House, De Montfort University";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeFirstName = "Dave";
            //assign the data to the property
            AStaff.FirstName = SomeFirstName;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.FirstName, SomeFirstName);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeLastName = "Peters";
            //assign the data to the property
            AStaff.LastName = SomeLastName;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.LastName, SomeLastName);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 StaffID = 1;
            //assign the data to the property
            AStaff.StaffID = StaffID;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, StaffID);
        }

        //[TestMethod]
        //public void StaffIDMinLessOne()
        //{
        //    //create an instance of the class we want to create
        //    clsStaff AStaff = new clsStaff();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    Int32 SomeStaffID = "";
        //    //invoke the method
        //    Error = AStaff.Valid(SomeStaffID);
        //    //test to see that the result is not OK 
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void ValidMethodOK()
        //{
        //    //create an instance of the class we want to create
        //    clsStaff AStaff = new clsStaff();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeLastName = "Peters";
        //    //invoke the method
        //    Error = AStaff.Valid(SomeLastName);
        //    //test to see that the result is OK
        //    Assert.AreEqual(Error, "");
        //}

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(FirstName,LastName,StaffID, Address);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeLastName = "";
            //invoke the method
            Error = AStaff.Valid(SomeLastName);
            //test to see that the result is not OK i.e there should be an error message 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeLastName = "a";
            //invoke the method
            Error = AStaff.Valid(SomeLastName);
            //test to see that the result is not OK i.e there should be an error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeLastName = "aa";
            //invoke the method
            Error = AStaff.Valid(SomeLastName);
            //test to see that the result is not OK i.e there should be an error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeLastName = "01234567890123456789012345678";
            //invoke the method
            Error = AStaff.Valid(SomeLastName);
            //test to see that the result is not OK i.e there should be an error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeLastName = "012345678901234567890123456789";
            //invoke the method
            Error = AStaff.Valid(SomeLastName);
            //test to see that the result is not OK i.e there should be an error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeLastName = "0123456789012345678901234567890";
            //invoke the method
            Error = AStaff.Valid(SomeLastName);
            //test to see that the result is not OK i.e there should be an error message 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeLastName = "012345678901234";
            //invoke the method
            Error = AStaff.Valid(SomeLastName);
            //test to see that the result is not OK i.e there should be an error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeLastName = "";
            //pad the string with characters
            SomeLastName = SomeLastName.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(SomeLastName);
            //test to see that the result is not OK i.e there should be an error message 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeFirstName = "";
            //invoke the method
            Error = AStaff.Valid(SomeFirstName);
            //test to see that the result is not OK i.e there should be an error message 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeFirstName = "a";
            //invoke the method
            Error = AStaff.Valid(SomeFirstName);
            //test to see that the result is not OK i.e there should be an error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeFirstName = "aa";
            //invoke the method
            Error = AStaff.Valid(SomeFirstName);
            //test to see that the result is not OK i.e there should be an error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeFirstName = "01234567890123456789012345678";
            //invoke the method
            Error = AStaff.Valid(SomeFirstName);
            //test to see that the result is not OK i.e there should be an error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeFirstName = "012345678901234567890123456789";
            //invoke the method
            Error = AStaff.Valid(SomeFirstName);
            //test to see that the result is not OK i.e there should be an error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeFirstName = "0123456789012345678901234567890";
            //invoke the method
            Error = AStaff.Valid(SomeFirstName);
            //test to see that the result is not OK i.e there should be an error message 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeFirstName = "012345678901234";
            //invoke the method
            Error = AStaff.Valid(SomeFirstName);
            //test to see that the result is not OK i.e there should be an error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeFirstName = "";
            //pad the string with characters
            SomeFirstName = SomeFirstName.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(SomeFirstName);
            //test to see that the result is not OK i.e there should be an error message 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Active, TestData);
        }


    }
}
