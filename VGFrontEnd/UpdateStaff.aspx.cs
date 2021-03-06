﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VGFrontEnd
{
    public partial class UpdateStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonFindStaffMember_Click(object sender, EventArgs e)
        {
            lblError.Text = "You have found a staff member";
        }

        protected void ButtonUpdateStaffDetails_Click(object sender, EventArgs e)
        {
            lblUpdateDetails.Text = "You have successfully updated staff details";
        }

        protected void ButtonMainMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffMenu.aspx");
        }
    }
}