using System;

namespace Class_Library
{

    public class clsCustomer
    {
        private int mCustomerId;
        private string mForename;
        private string mSurname;
        private string mAddress;
        private string mCounty;
        private string mPostCode;
        private string mEmailAddress;
        private string mPhoneNumber;

        public int CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }
        public string Forename
        {
            get
            {
                return mForename;
            }
            set
            {
                mForename = value;
            }
        }
        public string Surname
        {
            get
            {
                return mSurname;
            }
            set
            {
                mSurname = value;
            }
        }
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        public string County
        {
            get
            {
                return mCounty;
            }
            set
            {
                mCounty = value;
            }
        }
        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }
        public string EmailAddress
        {
            get
            {
                return mEmailAddress;
            }
            set
            {
                mEmailAddress = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }

        public bool Find(int CustomerId)
        {
            return true;
        }

        public string Valid(string Forename,
                            string Surname,
                            string Address,
                            string County,
                            string PostCode,
                            string EmailAddress,
                            string PhoneNumber)
        {
            String Error = "";

            //Not blank

            //forename is blank
            if(Forename.Length == 0)
            {
                Error = Error + "Forename must not be left blank, ";
            }
            //surname is blank
            if (Surname.Length == 0)
            {
                Error = Error + "Surname must not be left blank, ";
            }
            //address is blank
            if (Address.Length == 0)
            {
                Error = Error + "Address must not be left blank, ";
            }
            //county is blank
            if (County.Length == 0)
            {
                Error = Error + "County must not be left blank, ";
            }
            //postcode is blank
            if (PostCode.Length == 0)
            {
                Error = Error + "PostCode must not be left blank, ";
            }
            //email address is blank
            if (EmailAddress.Length == 0)
            {
                Error = Error + "Email Address must not be left blank, ";
            }
            //phone number is blank
            if (PhoneNumber.Length == 0)
            {
                Error = Error + "Phone Number must not be left blank, ";
            }

            //Max length
            //forename greater than 25
            if (Forename.Length > 25)
            {
                Error = Error + "Forename must be less than 25 characters, ";
            }
            //surname greater than 25
            if (Surname.Length > 25)
            {
                Error = Error + "Surname must be less than 25 chracters, ";
            }
            //address greater than 50
            if (Address.Length > 50)
            {
                Error = Error + "Address must be less than 50 characters, ";
            }
            //county greater than 50
            if (County.Length > 50)
            {
                Error = Error + "County must be less than 50, ";
            }
            //post code greater than 7
            if (PostCode.Length > 7)
            {
                Error = Error + "PostCode must be less than 7 characters, ";
            }
            //email address greater than 50
            if (EmailAddress.Length > 50)
            {
                Error = Error + "Email Address must be less than 50 ";
            }
            //phone number must be 15
            if (PhoneNumber.Length == 15)
            {
                Error = Error + "Phone Number must be 15 characters, ";
            }
            return Error;
        }
    }
}
