﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventsDelegatesAndLambda
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = "Clicked Me.";
        }

        protected void CountriesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutputLabel.Text = CountriesDropDown.SelectedIndex.ToString();
        }
    }
}