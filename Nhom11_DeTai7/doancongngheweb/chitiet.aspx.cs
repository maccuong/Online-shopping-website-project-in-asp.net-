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
using System.Collections;

public partial class chitiet : System.Web.UI.Page
{

    static DataTable gh = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        string ma = Request.QueryString["ma"].ToString();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dl"].ToString());
        SqlDataAdapter da = new SqlDataAdapter("select * from sanpham where masp='" + ma + "'", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "sanpham");
        DataColumn[] khoachinh = new DataColumn[1];
        khoachinh[0] = ds.Tables["sanpham"].Columns[0];
        ds.Tables["sanpham"].PrimaryKey = khoachinh;
        Gv2.DataSource = ds.Tables["sanpham"];
        Gv2.DataBind();



    }


    protected void Gv2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int sd = int.Parse(e.CommandArgument.ToString());
        string a = Gv2.DataKeys[sd].Value.ToString();
        if (Session["gh"] == null)
        {
            ArrayList ds = new ArrayList();
            ds.Add(a);
            Session["gh"] = ds;
        }
        else
        {
            ArrayList ds = (ArrayList)Session["gh"];
            ds.Add(a);
        }

        lbtongtien.Text = "Số lượng mặt hàng đã chọn là: " + ((ArrayList)Session["gh"]).Count;
    }
}
   