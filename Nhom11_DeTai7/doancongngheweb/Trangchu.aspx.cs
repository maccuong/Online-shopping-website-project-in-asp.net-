using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
public partial class Trangchu : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        string t = "Thuong";
        string email = Session["email1"].ToString();
        if (ktraloaitaikhoan(t, email) == true)
        {
            btthemsanpham.Visible = false;
            btXemtk.Visible = false;
        }
        else
        {
            btXemtk.Visible = true;
            btthemsanpham.Visible = true;
        }
        MultiView1.ActiveViewIndex = 0;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dl"].ToString());
        SqlDataAdapter da = new SqlDataAdapter("select * from sanpham", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "sanpham");
        DataColumn[] khoachinh = new DataColumn[1];
        khoachinh[0] = ds.Tables["sanpham"].Columns[0];
        ds.Tables["sanpham"].PrimaryKey = khoachinh;
        DataList1.DataSource = ds.Tables["sanpham"];
        DataList1.DataBind();
        

    }
    public bool ktraloaitaikhoan(string loaitk, string email)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dl"].ToString());
        SqlDataAdapter da = new SqlDataAdapter("select * from taikhoan where email ='" + email + "' ", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "taikhoan");
        if (string.Compare(loaitk, ds.Tables["taikhoan"].Rows[0].ItemArray[3].ToString()) == 0)
            return true;
        return false;
    }

    protected void Button7_Click(object sender, EventArgs e)
    {

    }

    public bool ktrkhoachinh(string pkhoachinh)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dl"].ToString());
        SqlDataAdapter da = new SqlDataAdapter("select * from sanpham ", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "sanpham");
        DataColumn[] khoachinh = new DataColumn[1];
        khoachinh[0] = ds.Tables["sanpham"].Columns[0];
        ds.Tables["sanpham"].PrimaryKey = khoachinh;
        DataRow ktra = ds.Tables["sanpham"].Rows.Find(pkhoachinh);
        if (ktra != null)
        {
            return true;

        }
        else
        {
            return false;
        }

    }

    public int themtaikhoan(string email, string mk)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dl"].ToString());
            SqlDataAdapter da = new SqlDataAdapter("select * from taikhoan ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "taikhoan");
            DataRow dtthem = ds.Tables["taikhoan"].NewRow();
            dtthem[1] = email;
            dtthem[2] = mk;
            ds.Tables["taikhoan"].Rows.Add(dtthem);
            SqlCommandBuilder builql = new SqlCommandBuilder(da);
            da.Update(ds, "taikhoan");
            return 1;

        }
        catch
        {
            return 0;
        }
    }
 
    protected void Btdangnhap_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
    protected void BtDangki_Click(object sender, EventArgs e)
    {
        if (themtaikhoan(txtEmailmoi.Text, txtmatkhaumoi.Text) == 0)
            lbthemtaikhoan.Text = "Đăng kí thất bại";
        else
            lbthemtaikhoan.Text = "Đăng kí thành công thành công";

        Response.Redirect("login.aspx");
    }

   
    protected void bttaotaikhoan_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }

    protected void btthemsanpham_Click1(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dl"].ToString());
        SqlDataAdapter da = new SqlDataAdapter("select matv , tentv , taikhoan.matk , diachi, dt , email ,loaitk from taikhoan , thanhvien where taikhoan.matk= thanhvien.matk ", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "taikhoan");
        Gvtk.DataSource = ds.Tables["taikhoan"];
        Gvtk.DataBind();
    }
   
}