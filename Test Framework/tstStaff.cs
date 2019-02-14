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


    }
}
