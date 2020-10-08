using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TalkRoom_Content : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int P_int_current = Convert.ToInt32(Application["current"]);
        Application.Lock();
        string P_str_chats = Application["chats"].ToString();
        string[] P_str_chat = P_str_chats.Split(',');
        for(int i=P_str_chat.Length-1;i>=0;i--)
        {
            if(P_int_current==0)
            {
                this.TextBox1.Text = P_str_chat[i].ToString();
            }
            else
            {
                this.TextBox1.Text = this.TextBox1.Text + "\n" + P_str_chat[i].ToString();
            }
        }
        Application.UnLock();
    }
}