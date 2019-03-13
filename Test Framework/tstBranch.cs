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

        [TestMethod]
        public void BranchPropertyOK()
        {
            //create an instance of the class we want to create
            clsBranch ABranch = new clsBranch();
            //create some test data to assign to the property
            string SomeBranch = "Northampton";
            //assign the data to the property
            ABranch.Branch = SomeBranch;
            //test to see that the two values are the same 
            Assert.AreEqual(ABranch.Branch, SomeBranch);

        }
        [TestMethod]
        public void Valid()
        {
            //Create an instance of the class we want to create
            clsBranch ABranch = new clsBranch();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some tests data to test the method 
            string SomeBranch = "Northampton";
            //invoke the method
            Error = ABranch.Valid(SomeBranch);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void BranchMinlessOne()
        {
            //create an instance of the class we want to create
            clsBranch ABranch = new clsBranch();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeBranch = "";
            //invoke the method
            Error = ABranch.Valid(SomeBranch);
            //test to see that the result is NOT OK i.e there should be an error message 
            Assert.AreNotEqual(Error, "");
        }




    }
}
