using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Response_ChongDinXiang2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            string name = Request.Params["Name"];
            string sex = Request.Params["Sex"];
            Response.Write("欢迎" + name + sex);
        }
    }
}