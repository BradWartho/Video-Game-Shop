﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VGFrontEnd
{
    public partial class UpdateBranch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("BranchMenu.aspx");
        }

        protected void BntUpdateButton_Click(object sender, EventArgs e)
        {
            lblUpdateButton.Text = "Succesfully Updated Branch";
        }
    }
}