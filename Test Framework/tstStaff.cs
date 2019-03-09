using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffID()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            Int32 StaffID;
            //assign a value to the variable
            StaffID = 123;
            //try yo send some data to the StaffID property
            AStaff.StaffID = StaffID;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AStaff.StaffID, StaffID);
        }

        [TestMethod]
        public void StaffFirstName()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a variable to store the name of a staff member
            string SomeStaffFirstName;
            //assign a name to the member
            SomeStaffFirstName = "David";
            //try to send some data to the FirstName property
            AStaff.StaffFirstName = SomeStaffFirstName;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AStaff.StaffFirstName, SomeStaffFirstName);
        }

        [TestMethod]
        public void StaffLastName()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a variable to store the name of a staff member
            string SomeStaffLastName;
            //assign a name to the member
            SomeStaffLastName = "Peters";
            //try to send some data to the LastName property
            AStaff.StaffLastName = SomeStaffLastName;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AStaff.StaffLastName, SomeStaffLastName);
        }

        [TestMethod]
        public void Valid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see if a valid method exists
            AStaff.Valid("David Peters");
            
        }

        [TestMethod]
        //test that the first name validation throws an error when first name is blank
        public void StaffFirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a variable to record the result of the validation test
            Boolean OK;
            //test the valid method with a blank string
            OK = AStaff.Valid("");
            //assert that the outcome should be false
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffFirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(21);
            //test the valid method with a two character string
            OK = AStaff.Valid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffFirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(400);
            //test the valid method with a two character string
            OK = AStaff.Valid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);
        }

        //[TestMethod]
        //public void StaffFirstNameMinBoundary()
        //{
        //    //create an instance of the class we want to create
        //    clsStaff AStaff = new clsStaff();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeStaffFirstName = "a";
        //    //invoke the method
        //    Error = AStaff.Valid(SomeStaffFirstName);
        //    //test to see that the result is ok ie.there was no error message returned
        //    Assert.AreEqual(Error, "");
        //}












        [TestMethod]
        //test that the first name validation throws an error when first name is blank
        public void StaffLastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a variable to record the result of the validation test
            Boolean OK;
            //test the valid method with a blank string
            OK = AStaff.Valid("");
            //assert that the outcome should be false
            Assert.IsFalse(OK);
        }



    }
}
