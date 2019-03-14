using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstBranchCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsBranchCollection AllBranchs = new clsBranchCollection();
            //test to see that  it exisits 
           Assert.IsNotNull(AllBranchs);
        }
        [TestMethod]
        public void CountBranchOK()
        {
            clsBranchCollection AllBranchs = new clsBranchCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 1;
            //assign the data to the property 
            AllBranchs.Count = SomeCount;
            //test to see that two values are the same
            Assert.AreEqual(AllBranchs.Count, SomeCount);
        }
        //[TestMethod]
        //public void AllBranchOK()
        //{
        //    //create an instance of class we want to create 
        //    clsBranchCollection Staff = new clsBranchCollection();
        //    //create some test data to assign to the property
            
        //    //add an item to the list 
        //    //create the item of test data
        //    clsBranch TestItem = new clsBranch();
        //    //set its properties 
        //    TestItem.BranchNo = 1;
        //    TestItem.Branch = "Northampton";           
        //    //add the item to the test list
        //    TestList.Add(TestItem);
        //    //assign the data to the property
        //    Staff.AllBranch = TestList;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(Staff.AllBranch, TestList);
        //}

    }
}
