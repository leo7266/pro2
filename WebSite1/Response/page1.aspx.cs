using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 在页面中输出数据_page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            char c = 'a';
            string s = "Hello World";
            char[] cs = { 'h', 'a', 'p', 'p', 'y', ',', 'b', 'i', 'r', 't', 'h', 'd', 'a', 'y' };
            Page p = new Page();
            Response.Write("输出单个字符"+c+"<br/>");
            Response.Write("输出一个字符串"+s+"<br/>");
            Response.Write("输出字符数组");
            Response.Write(cs,0,cs.Length);
            Response.Write("<br/>");
            Response.Write("输出一个对象" + p + "<br/>");
            Response.Write("输出一个文件");
            Response.Write(Server.MapPath(@"test.txt"));
        }
    }
}