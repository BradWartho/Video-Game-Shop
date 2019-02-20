using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstBranch
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsBranch ABranch = new clsBranch();
           



        }
        [TestMethod]
        public void BranchID()
        {
            //create an instance of the class we want to create
            clsBranch ABranch = new clsBranch();
            Int32 BranchID;
            //assign a value to the variable
            BranchID = 123;
            //i tried to send some data to the branchID property
            ABranch.BranchID = BranchID;
           
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(ABranch.BranchID, BranchID);

        }

    }
}
