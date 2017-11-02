using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;

namespace eScout.Models
    
{
    public class EmployeeInfoDb
    {
        private SqlConnection con;



        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["eScout_DevConnectionString"].ToString();
            con = new SqlConnection(constring);
        }



       
        // add employee
        public bool Emp_Name(EmployeeInfo smodel)
    {
        connection();
        SqlCommand cmd = new SqlCommand(" Insert into emp_info values(@emp_name,@emp_email,@emp_number,@doj,@dol,@cell_number,@is_active,@dob,@designation_id)", con);

   
            cmd.Parameters.AddWithValue("@emp_name", smodel.emp_name);
            cmd.Parameters.AddWithValue("@emp_email", smodel.emp_email);
            cmd.Parameters.AddWithValue("@emp_number", smodel.emp_number);
            cmd.Parameters.AddWithValue("@doj", smodel.doj);
            cmd.Parameters.AddWithValue("@dol", smodel.dol);
            cmd.Parameters.AddWithValue("@cell_number", smodel.cell_number);
            cmd.Parameters.AddWithValue("@is_active", smodel.is_active);
            cmd.Parameters.AddWithValue("@dob", smodel.dob);
            cmd.Parameters.AddWithValue("@designation_id", smodel.designation_id);


            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

              if (i >= 1)
                return true;
              else
                return false;
               }
      }
}







