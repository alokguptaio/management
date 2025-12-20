using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
namespace tblemployee
{
    public partial class LoginFrom : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=LAPTOP-5ENK6B3O\\SQLEXPRESS02;initial catalog=db8_12825;integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblregistrations where UserEmail='" + tbemail.Text+ "' and UserPassword='"+ tbpassword.Text + "'", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.Close();
            if (dt.Rows.Count == 0)
            {
                lblmsg.Text = "Login failed !!";
            }
            else
            {
                Session["uid"] = dt.Rows[0]["UserId"];
                Response.Redirect("HomeFrom.aspx");
            }
        }
    }
}