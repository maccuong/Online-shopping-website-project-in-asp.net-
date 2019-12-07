using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public bool ktramatkhau(string email, string mk)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dl"].ToString());
        SqlDataAdapter da = new SqlDataAdapter("select * from taikhoan", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "taikhoan");

        for (int i = 0; i < ds.Tables["taikhoan"].Rows.Count; i++)
            if (string.Compare(email, ds.Tables["taikhoan"].Rows[i].ItemArray[1].ToString()) == 0 && string.Compare(mk, ds.Tables["taikhoan"].Rows[i].ItemArray[2].ToString()) == 0)
                return true;
        return false;

    }
   

    protected void Btdangnhap1_Click(object sender, EventArgs e)
    {


        if (ktramatkhau(txtemail.Text, txtmatkhau.Text) == false)
        {

            Lbdangnhap.Visible = true;
            Lbdangnhap.Text = "Sai email hoặc mật khẩu";
        }
        else
        {
            Session["email1"] = txtemail.Text;
            Response.Redirect("trangchu.aspx");
        }
    }
}