using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
    }
   

    protected void btn_dn_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("trangchu.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("chitiet.aspx");
    }
}
