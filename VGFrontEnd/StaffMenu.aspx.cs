using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VGFrontEnd
{
    public partial class StaffMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonStaffEntry_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffEntry.aspx");
        }

        protected void ButtonStaffDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffDelete.aspx");
        }

        protected void ButtonListStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListStaff.aspx");
        }

        protected void ButtonUpdateStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateStaff.aspx");
        }

        protected void ButtonHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }
    }
}