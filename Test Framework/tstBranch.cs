using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstBranch

   
    {
        string BranchID = "12";
    string BranchName = "GAME";
        string AddressLine = "Northampton";
    string City = "Northamptonshire";
    string Postcode = "NN4 804";
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
            //invoke the method
            Error = ABranch.Valid(BranchID, BranchName, AddressLine, City, Postcode);
            //test to see that the result is OK
            Assert.AreEqual(Error, "");
        }


        //}
        //[TestMethod]
        //public void BranchMinlessOne()
        //{
        //    //create an instance of the class we want to create
        //    clsBranch ABranch = new clsBranch();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeBranch = "";
        //    //invoke the method
        //    Error = ABranch.Valid(SomeBranch);
        //    //test to see that the result is NOT OK i.e there should be an error message 
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void BranchMinBoundary()
        //{
        //    //create an instance of the class we want to create
        //    clsBranch ABranch = new clsBranch();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeBranch = "a";
        //    //invoke the method
        //    Error = ABranch.Valid(SomeBranch);
        //    //test to see that the result is NOT OK i.e there should be an error message 
        //    Assert.AreEqual(Error, "");

        //}
        //[TestMethod]
        //public void BranchMinPlusOne()
        //{
        //    //create an instance of the class we want to create
        //    clsBranch ABranch = new clsBranch();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeBranch = "aa";
        //    //invoke the method
        //    Error = ABranch.Valid(SomeBranch);
        //    //test to see that the result is NOT OK i.e there should be an error message 
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void BranchMaxLessOne()
        //{
        //    //create an instance of the class we want to create
        //    clsBranch ABranch = new clsBranch();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeBranch = "01234567890123456789012345678";
        //    //invoke the method
        //    Error = ABranch.Valid(SomeBranch);
        //    //test to see that the result is NOT OK i.e there should be an error message 
        //    Assert.AreEqual(Error, "");
        //}
        //[TestMethod]
        //public void BranchMaxBoundary()
        //{
        //    //create an instance of the class we want to create
        //    clsBranch ABranch = new clsBranch();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeBranch = "012345678901234567890123456789";
        //    //invoke the method
        //    Error = ABranch.Valid(SomeBranch);
        //    //test to see that the result is NOT OK i.e there should be an error message 
        //    Assert.AreEqual(Error, "");
        //}
        //[TestMethod]
        //public void BranchMid()
        //{
        //    //create an instance of the class we want to create
        //    clsBranch ABranch = new clsBranch();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeBranch = "0123456789012345678901234";
        //    //invoke the method
        //    Error = ABranch.Valid(SomeBranch);
        //    //test to see that the result is NOT OK i.e there should be an error message 
        //    Assert.AreEqual(Error, "");
        //}
        //[TestMethod]
        //public void BranchMaxPlusOne()
        //{
        //    //create an instance of the class we want to create
        //    clsBranch ABranch = new clsBranch();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeBranch = "01234567890123456789012345678901234567890";
        //    //invoke the method
        //    Error = ABranch.Valid(SomeBranch);
        //    //test to see that the result is NOT OK i.e there should be an error message 
        //    Assert.AreEqual(Error, "");
        //}
        //[TestMethod]
        //public void BranchExtremeMax()
        //{
        //    //create an instance of the class we want to create
        //    clsBranch ABranch = new clsBranch();
        //    //create a string variable to store the result of the validation
        //    String Error = "";
        //    //create some test data to test the method
        //    string SomeBranch = "";
        //    //pad the string with characters
        //    SomeBranch = SomeBranch.PadRight(500, 'a');
        //    //invoke the method
        //    Error = ABranch.Valid(SomeBranch);
        //    //test to see that the result is not OK i.e there should be an error message 
        //    Assert.AreNotEqual(Error, "");
        //}
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsBranch AnBranch = new clsBranch();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 BranchID = 1;
            //invoke the method
            Found = AnBranch.Find(BranchID);
            //test to see that the rewsult is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE 
            clsBranch AnBranch = new clsBranch();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property 
            AnBranch.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnBranch.Active, TestData);
        }


    }




}

