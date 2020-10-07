using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 上传文件_page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            DropListLoad();
            this.DropDownList1.SelectedIndex = 0;
            this.Image1.ImageUrl = "~/Image/image3726.jpg";
        }
    }

    public void DropListLoad()
    {
        ArrayList arrList = new ArrayList();
        arrList.Add("图片1");
        arrList.Add("图片2");
        arrList.Add("图片3");
        this.DropDownList1.DataSource = arrList;
        this.DropDownList1.DataBind();
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int num = this.DropDownList1.SelectedIndex;
        switch(num)
        {
            case 0:
                this.Image1.ImageUrl = "~/Image/image3726.jpg";
                break;
            case 1:
                this.Image1.ImageUrl = "~/Image/image3727.jpg";
                break;
            case 2:
                this.Image1.ImageUrl = "~/Image/image3728.jpg";
                break;
            default:
                break;
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        bool bSave = false;
        if(this.FileUpload1.HasFile)
        {
            string fileExtension = System.IO.Path.GetExtension(this.FileUpload1.FileName).ToLower();
            string[] extensions = { ".gif", ".bmp", ".jpg", ".png" };
            for (int i=0;i<extensions.Length;i++)
            {
                if(fileExtension==extensions[i])
                {
                    bSave = true;
                }
            }

            if (bSave==true)
            {
                try
                {
                    this.Image1.ImageUrl = "~/image/" + this.FileUpload1.FileName;
                    this.FileUpload1.SaveAs("D:\\data\\" + this.FileUpload1.FileName);
                    this.Label1.Text = "文件上传成功";
                    this.Label1.Text += "<br/>";
                    this.Label1.Text += "<li>" + "原文件路径：" + this.FileUpload1.PostedFile.FileName;
                    this.Label1.Text += "<br/>";
                    this.Label1.Text += "<li>" + "文件大小：" + this.FileUpload1.PostedFile.ContentLength;
                    this.Label1.Text += "<br/>";
                    this.Label1.Text += "<li>" + "文件类型：" + this.FileUpload1.PostedFile.ContentType;
                }
                catch 
                {
                    this.Label1.Text += "文件上传不成功";
                }

            }
            else
            {
                this.Label1.Text = "只能上传后缀为.gif,.jpg,.bmp,.png的文件";
            }
        }
    }
}