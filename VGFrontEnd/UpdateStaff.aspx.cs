using System;
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
            lblError.Text = "Successfully found staff member";
        }

        protected void ButtonUpdateDetails_Click(object sender, EventArgs e)
        {
            lblUpdateDetails.Text = "Successfully updated details";
        }

        protected void ButtonMainMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffMenu.aspx");
        }
    }
}