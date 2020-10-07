using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 网站会员登录_page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(this.TextBox1.Text=="sa" & this.TextBox2.Text=="123")
        {
            Response.Redirect("page2.aspx");
        }
        else
        {
            Response.Write("用户名或密码不正确");
        }
    }
}