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
public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dl"].ToString());
        SqlDataAdapter da = new SqlDataAdapter("select * from sanpham", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "sanpham");
        DataColumn[] khoachinh = new DataColumn[1];
        khoachinh[0] = ds.Tables["sanpham"].Columns[0];
        ds.Tables["sanpham"].PrimaryKey = khoachinh;
        Gv1.DataSource = ds.Tables["sanpham"];
        Gv1.DataBind();
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
   
    public int them(string masp, string tensp, string gia, string mota, string hinhanh)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dl"].ToString());
            SqlDataAdapter da = new SqlDataAdapter("select * from sanpham ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "sanpham");
            if (ktrkhoachinh(masp) == true)
                return 2;
            DataRow dtthem = ds.Tables["sanpham"].NewRow();
            dtthem[0] = masp;
            dtthem[1] = tensp;
            dtthem[2] = gia;
            dtthem[3] = mota;
            dtthem[4] = hinhanh;
            ds.Tables["sanpham"].Rows.Add(dtthem);
            SqlCommandBuilder builql = new SqlCommandBuilder(da);
            da.Update(ds, "sanpham");
            return 1;

        }
        catch
        {
            return 0;
        }
    }
    protected void btthem_Click(object sender, EventArgs e)
    {
        if (them(txtmasp.Text, txttensp.Text, txtgia.Text, txtmota.Text, fulhinhanh.FileName) == 0)
            lbthemsanpham.Text = "Mã sản phẩm đã tồn tại";
        else
            if (them(txtmasp.Text, txttensp.Text, txtgia.Text, txtmota.Text, fulhinhanh.FileName) == 0)
                lbthemsanpham.Text = "Thêm thất bại";
            else
                lbthemsanpham.Text = "Thêm sản phẩm thành công";
        string folderPath = Server.MapPath("~/hinh/");
      
        if (!Directory.Exists(folderPath))
        {
           
            Directory.CreateDirectory(folderPath);
        }
     
        fulhinhanh.SaveAs(folderPath +
                    Path.GetFileName(fulhinhanh.FileName));

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dl"].ToString());
        SqlDataAdapter da = new SqlDataAdapter("select * from sanpham", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "sanpham");
        Gv1.DataSource = ds.Tables["sanpham"];
        Gv1.DataBind();
    }
   
  
    public int xoasanpham(string pkhoachinh)
    {

        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dl"].ToString());
            SqlDataAdapter da = new SqlDataAdapter("select * from sanpham ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "sanpham");
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds.Tables["sanpham"].Columns[0];
            ds.Tables["sanpham"].PrimaryKey = khoachinh;
            DataRow dr = ds.Tables["sanpham"].Rows.Find(pkhoachinh);

            if (dr != null)
            {
                dr.Delete();
            }
            SqlCommandBuilder bd = new SqlCommandBuilder(da);
            da.Update(ds, "sanpham");
            return 1;
        }
        catch
        {
            return 0;
        }
    }
    protected void Gv1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string s = Gv1.DataKeys[e.RowIndex].Value.ToString();
        if (xoasanpham(s) == 1)
            lbthemsanpham.Text = "Xóa thành công ";
        else
            lbthemsanpham.Text = "Xóa thất bại";

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dl"].ToString());
        SqlDataAdapter da = new SqlDataAdapter("select * from sanpham ", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "sanpham");
        Gv1.DataSource = ds.Tables["sanpham"];
        Gv1.DataBind();

    }
    public int suasanpham(string pkhoachinh, string tenspmoi, string giamoi, string motamoi)
    {

        try
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dl"].ToString());
            SqlDataAdapter da = new SqlDataAdapter("select * from sanpham ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "sanpham");
            DataRow dtthem = ds.Tables["sanpham"].Rows.Find(pkhoachinh);
            dtthem[1] = tenspmoi;
            dtthem[2] = giamoi;
            dtthem[3] = motamoi;         
            SqlCommandBuilder builql = new SqlCommandBuilder(da);
            da.Update(ds, "sanpham");
            return 1;
        }
        catch
        {
            return 0;
        }
    }
    protected void Gv1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //string tensp, gia, mota, hinhanh, masp;
        //tensp = e.NewValues["tensp"].ToString();
        //gia = e.NewValues["gia"].ToString();
        //mota = e.NewValues["mota"].ToString();
        //hinhanh = e.NewValues["hinhanh"].ToString();
        //masp = e.NewValues["masp"].ToString();
        //dssanpham.UpdateParameters.Add("tenspmoi", tensp);
        //dssanpham.UpdateParameters.Add("giamoi", gia);
        //dssanpham.UpdateParameters.Add("motamoi", mota);
        //dssanpham.UpdateParameters.Add("hinhanhmoi", hinhanh);
        //dssanpham.UpdateParameters.Add("maspmoi", masp);
        //dssanpham.Update();
        
    }
    protected void Gv1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Gv1.EditIndex = e.NewEditIndex;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dl"].ToString());
        SqlDataAdapter da = new SqlDataAdapter("select * from sanpham ", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "sanpham");
        Gv1.DataSource = ds.Tables["sanpham"];
        Gv1.DataBind();
       
    }
    protected void Gv1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        Gv1.EditIndex = -1;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dl"].ToString());
        SqlDataAdapter da = new SqlDataAdapter("select * from sanpham ", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "sanpham");
        Gv1.DataSource = ds.Tables["sanpham"];
        Gv1.DataBind();
    }
}