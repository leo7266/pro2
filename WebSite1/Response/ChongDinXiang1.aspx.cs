using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Response_ChongDinXiang : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = this.TextBox1.Text.Trim();
        string sex = "先生";
        if(this.rb2.Checked==true)
        {
            sex = "女士";
        }
        Response.Redirect(@"~\Response\ChongDinXiang2.aspx?Name=" + name + "&Sex=" + sex);
    }
}