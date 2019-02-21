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
        public void FirstName()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a variable to store the name of a staff member
            string SomeFirstName;
            //assign a name to the member
            SomeFirstName = "David";
            //try to send some data to the FirstName property
            AStaff.FirstName = SomeFirstName;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AStaff.FirstName, SomeFirstName);
        }

        [TestMethod]
        public void LastName()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a variable to store the name of a staff member
            string SomeLastName;
            //assign a name to the member
            SomeLastName = "Peters";
            //try to send some data to the LastName property
            AStaff.LastName = SomeLastName;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AStaff.LastName, SomeLastName);
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
        public void FirstNameMinLessOne()
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
        public void FirstNameMaxPlusOne()
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
        public void FirstNameExtremeMax()
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

        [TestMethod]
        //test that the first name validation throws an error when first name is blank
        public void LastNameMinLessOne()
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
