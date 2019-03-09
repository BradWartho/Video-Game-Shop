using System;

namespace Class_Library
{
    public class clsStaff
    {
        public int StaffID { get; set; }
        public string StaffFirstName { get; set; }
        public string StaffLastName { get; set; }

        public Boolean Valid(string StaffFirstName)
        {
            //var to record any erros found in first name assuming all is ok
            Boolean OK = true;
            //test to see if the first name has zero characters
            if (StaffFirstName.Length == 0)
            {
                //set OK to false
                OK = false;
            }
            //test to see that the string is no more than 20 characters
            if (StaffFirstName.Length > 20)
            {
                //set OK to false
                OK = false;
            }
            //return the results of the tests
            return OK;
        }

    }
}