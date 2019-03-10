using System;
using Class_Library;
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
            //test to see that it exists
            Assert.IsNotNull(ABranch);



        }

        [TestMethod]
        public void BranchIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsBranch ABranch = new clsBranch();
            //crate some tests data to assign to the property
            Int32 BranchNo = 1;
            //assign the data to the property
            ABranch.BranchNo = BranchNo;
            //test to see that the two values are the same
            Assert.AreEqual(ABranch.BranchNo, BranchNo);

        }
    }
}
