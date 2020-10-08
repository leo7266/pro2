using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TalkRoom_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }   


    protected void Button1_Click(object sender, EventArgs e)
    {
        int P_int_current = Convert.ToInt32(Application["current"]);
        Application.Lock();
        if (P_int_current == 0 || P_int_current > 20)
        {
            P_int_current = 0;
            Application["chats"] = this.TextBox1.Text.Trim() + "(" + DateTime.Now.ToString() + ")";

        }
        else
        {
            Application["chats"] = Application["chats"].ToString() + "," + this.TextBox1.Text.Trim() + "(" + DateTime.Now.ToString() + ")";
        }
        P_int_current += 1;
        Application["current"] = P_int_current;
        Application.UnLock();
    }
}