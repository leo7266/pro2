using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 上传大文件_page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if(this.FileUpload1.HasFile)
            {
                this.TextBox1.Text = this.FileUpload1.PostedFile.FileName;
                string upName = this.FileUpload1.FileName;
                string nameLast = upName.Substring(upName.LastIndexOf("."));
                string fileName = this.TextBox1.Text + nameLast;
                string path = "D:\\Data\\" + fileName;
                this.FileUpload1.PostedFile.SaveAs(path);
                RegisterStartupScript("true", "<script>alert('上传成功')</script>");
            }
            
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message.ToString());
            RegisterStartupScript("true", "<script>alert('上传失败')</script>");
        }
    }
}