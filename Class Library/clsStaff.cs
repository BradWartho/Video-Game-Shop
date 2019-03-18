using System;

namespace Class_Library
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        public string FirstName { get; set; }
        public int StaffID { get; set; }
        public string LastName { get; set; }

        public string Valid(string someLastName)
        {
            //string variable to store the error message
            string Error = "";
           //if the last name is more than 30 characters
           if (someLastName.Length > 30)
            {
                //return an error message
                Error = "The last name cannot have more than 30 characters";
            }
           if (someLastName.Length == 0)
            {
                //return an error message
                Error = "The last name may not be blank!";
            }
            return Error;
        }

        public bool Find(int staffID)
        {
            //always return true
            return true;
        }
    }
}