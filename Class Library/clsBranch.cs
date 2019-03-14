using System;

namespace Class_Library
{
    public class clsBranch
    {
        private int mBrancho;
        public int BranchNo
        {
            get
            {
                return mBrancho;
            }
            set
            {
                mBrancho = value;
            }
        }


        public object Branch { get; set; }
        public bool Active { get; set; }

        public string Valid(string branchID, string branchName, string addressLine, string city, string postcode)
        {
            return "";
        }

        public bool Find(int branchID)
        {
            //always return true
            mBrancho = 1;
            return true;
        }

        //public string Valid(string someBranch)
        //{
        //    clsBranch ABranch = new clsBranch();
        //    //string variable to store the error message 
        //    string Error = "";
        //    // if the name of the Branch is not blank
        //    if (someBranch.Length > 50 )
        //    {
        //        //return a blank string
        //        return "the Branch Name cannot have more than 50 characters ";
        //    }
        //   if (someBranch.Length ==0)
        //    {
        //        //otherwise return an error message 
        //        return "the Branch name may not be blank!";
        //    }

        //}
    }
}