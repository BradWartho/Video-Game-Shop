using System.Collections.Generic;

namespace Class_Library
{
    public class clsStaffCollection
    {
        //private data member fot the AllStaff list
        private List<clsStaff> mAllStaff = new List<clsStaff>();
        //public property for count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllStaff.Count;
            }
            set
            {
                //
            }
        }

        //public property for allStaff
        public List<clsStaff> AllStaff
        {
            //getter sends data to requesting code
            get
            {
                //return the private data member
                return mAllStaff;
            }
            //setter accepts the data from other objects
            set
            {
                //assign tthe incoming value to the private data member
                mAllStaff = value;
            }


        }

        //public constructor for the class
        public clsStaffCollection()
        {
            //create an instance of the staff class to store a staff member 
            clsStaff AStaff = new clsStaff();
            //set the Last name to Peters
            AStaff.LastName = "Peters";
            //add the name to the private list of staff
            mAllStaff.Add(AStaff);
            //re initialise the AStaff object to accept a new item
            AStaff = new clsStaff();
            //set the name to Keter
            AStaff.LastName = "Keter";
            //add the second name to the private list of staff
            mAllStaff.Add(AStaff);
            //the private list now contains two members 

        }







       

    }

}