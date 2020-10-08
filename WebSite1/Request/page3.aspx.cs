using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Request_page3 : System.Web.UI.Page
{
    //Request通过Browser属性获取客户端浏览器信息
    protected void Page_Load(object sender, EventArgs e)
    {
        //HttpBrowserCapabilities类对象用于获取Request对象的Browser属性的返回值
        HttpBrowserCapabilities b = Request.Browser;
        Response.Write("客户端浏览器信息");
        Response.Write("<hr>");
        Response.Write("类型：" + b.Type + "<br/>");
        Response.Write("类型：" + b.Type + "<br/>");
        Response.Write("类型：" + b.Type + "<br/>");
        Response.Write("类型：" + b.Type + "<br/>");
        Response.Write("类型：" + b.Type + "<br/>");
        Response.Write("类型：" + b.Type + "<br/>");
        Response.Write("类型：" + b.Type + "<br/>");


    }
}