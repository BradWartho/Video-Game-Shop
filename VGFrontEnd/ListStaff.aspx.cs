using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VGFrontEnd
{
    public partial class ListStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonFilterStaff_Click(object sender, EventArgs e)
        {
            lblError.Text = "You have successfully filtered the staff";
        }

        protected void ButtonMainMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffMenu.aspx");
        }
    }
}