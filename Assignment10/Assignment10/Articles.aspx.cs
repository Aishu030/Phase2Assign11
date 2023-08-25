using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment10
{
    public partial class Articles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                LblMsg.Visible = true;
                SqlConnection con = new SqlConnection("server=LAPTOP-EA5C4MP1;database=Assignment10Db;trusted_connection=true;");
                SqlCommand cmd = new SqlCommand("select * from Articles", con);
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                GridViewArticle.DataSource = ds;
                GridViewArticle.DataBind();
                LblMsg.Text = "Number of Articles available: " + ds.Tables[0].Rows.Count;

            }
            catch (Exception ex)
            {

                LblMsg.Text = "Error " + ex.Message;

            }
        }

    }
}
