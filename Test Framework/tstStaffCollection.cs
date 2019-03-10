using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void CountStaffOK()
        {
            //create an instance of class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllStaff.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }

        [TestMethod]
        public void AllStaffOK()
        {
            //create an instance of class we want to create 
            clsStaffCollection Staff = new clsStaffCollection();
            //create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list 
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties 
            TestItem.StaffID = 1;
            TestItem.FirstName = "David";
            TestItem.LastName = "Peters";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Staff.AllStaff = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.AllStaff, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of class we want to create 
            clsStaffCollection Staff = new clsStaffCollection();
            //create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list 
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties 
            TestItem.StaffID = 1;
            TestItem.FirstName = "David";
            TestItem.LastName = "Peters";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Staff.AllStaff = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoStaffPresent()
        {
            //create an instance of class we want to create 
            clsStaffCollection Staff = new clsStaffCollection();
            //test to see that the two values are the same 
            Assert.AreEqual(Staff.Count, 2);
        }
    }
}
