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
    public partial class RegistrationFrom : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=LAPTOP-5ENK6B3O\\SQLEXPRESS02;initial catalog=db8_12825;integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnregistration_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ProcRegistration", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@action", "Insert");
            cmd.Parameters.AddWithValue("@UserName", tbname.Text);
            cmd.Parameters.AddWithValue("@UserGender", rblgender.SelectedValue);
            cmd.Parameters.AddWithValue("@DOB", txtdob.Text);
            cmd.Parameters.AddWithValue("@UserCourse", ddlcourse.SelectedValue);
            cmd.Parameters.AddWithValue("@UserEmail", tbemail.Text);
            cmd.Parameters.AddWithValue("@UserPassword", tbpassword.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            lblmsg.Text = "You Are Registered Successfully !!";
            lblmsg.ForeColor = Color.Red;
            


        }
    }
}