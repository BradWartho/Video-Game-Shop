using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VGFrontEnd
{
    public partial class Add_Branch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAddBranch_Click(object sender, EventArgs e)
        {

        }

        protected void BtnBackBranch_Click(object sender, EventArgs e)
        {
            Response.Redirect("BranchMenu.aspx");
        }
    }
}