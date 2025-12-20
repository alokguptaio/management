using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace tblemployee
{
    public partial class HomeFrom : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=LAPTOP-5ENK6B3O\\SQLEXPRESS02;initial catalog=db8_12825;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Showdata();
            }

        }
        public void Showdata()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblregistrations where UserId='" + Session["uid"]+"'", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.Close();
            if (dt.Rows.Count>0){
                lblname1.Text = dt.Rows[0]["UserName"].ToString();
                lblname.Text = dt.Rows[0]["UserName"].ToString();
                lblgender.Text = dt.Rows[0]["UserGender"].ToString();
                lbldob.Text = dt.Rows[0]["DOB"].ToString();
                lblcourse.Text = dt.Rows[0]["UserCourse"].ToString();
                lblemail.Text = dt.Rows[0]["UserEmail"].ToString();
                lblpassword.Text = dt.Rows[0]["UserPassword"].ToString();

            }
            else
            {
                lblname.Text = "No Data Found";            }

        }

        protected void lbledit_Click(object sender, EventArgs e)
        {

        }

        protected void lbldelete_Click(object sender, EventArgs e)
        { 
            con.Open();
            SqlCommand cmd = new SqlCommand("ProcRegistration",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "Delete");
            cmd.Parameters.AddWithValue("@UserId", Session["uid"]);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("LoginFrom.aspx");




        }
    }
}