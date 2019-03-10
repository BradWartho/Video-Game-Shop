using System;

namespace Class_Library
{
    public class clsBranch
    {
        public int BranchNo { get; set; }
        public object Branch { get; set; }

        public string Valid(string someBranch)
        {
            // if the name of the Branch is not blank
            if (someBranch !="")
            {
                //return a blank string
                return "";
            }
            else
            {
                //otherwise return an error message 
                return "the Branch name may not be blank!";
            }
            
        }
    }
}