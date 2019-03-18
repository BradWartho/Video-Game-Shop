using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VGFrontEnd
{
    public partial class BranchMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBranch.aspx");
        }

        protected void btnDelete_Click1(object sender, EventArgs e)
        {
            Response.Redirect("DeleteBranch.aspx");
        }

        protected void btnUpdate_Click1(object sender, EventArgs e)
        {
            Response.Redirect("UpdateBranch.aspx");
        }

        protected void btnFilterByPostCode_Click(object sender, EventArgs e)
        {
            Response.Redirect("BranchFilterByPostCode.aspx");
        }
    }
}