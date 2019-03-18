using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VGFrontEnd
{
    public partial class BranchFilterByPostCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBackFilter_Click1(object sender, EventArgs e)
        {
            Response.Redirect("BranchMenu.aspx");
        }
    }
}