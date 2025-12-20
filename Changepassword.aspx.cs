using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
namespace tblemployee
{
    public partial class Changepassword : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=LAPTOP-5ENK6B3O\\SQLEXPRESS02;initial catalog=db8_12825;integrated security=true");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncp_Click(object sender, EventArgs e)
        {
            if (txtnewpassword.Text == txtconfirmnewpassword.Text)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ProcRegistration", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", "Cp");
                cmd.Parameters.AddWithValue("@UserId", Session["uid"]);
                cmd.Parameters.AddWithValue("@UserPassword", txtcurrentpassword.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtnewpassword.Text);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i == 0)
                {
                    lblmsg.Text = "Current Password do not match !!";
                    lblmsg.ForeColor = Color.Red;

                }
                else
                {
                    lblmsg.Text = "Your Password Has Been Changed Successfully !!";
                    lblmsg.ForeColor = Color.Red;
                }
            }
            else
            {
                lblmsg.Text = " Password do not match !!";
                lblmsg.ForeColor = Color.Red;

            }
       
        }
    }
}