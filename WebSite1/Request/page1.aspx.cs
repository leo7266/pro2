using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Request_page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Request通过Params,QueryString属性获取页面的传值
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect(@"~\Request\page2.aspx?value=this is a test value");
    }
}