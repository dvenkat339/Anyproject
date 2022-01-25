using MVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_CRUD.Repository
{
    public class StudentRepository
    {
        private SqlConnection con;
       
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["MyConn"].ToString();
            con = new SqlConnection(constr);

        }
        
        public bool AddStudent(StudentModel obj)
        {

            connection();
            SqlCommand com = new SqlCommand("sp_AddStudent", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Name", obj.Name);
            com.Parameters.AddWithValue("@DOB", obj.DOB);
            com.Parameters.AddWithValue("@CreatedOn", obj.CreatedOn);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }


        }

        public List<StudentModel> GetAllStudents()
        {
            connection();
            List<StudentModel> StdList = new List<StudentModel>();
            SqlCommand com = new SqlCommand("GetEmployees", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            //Bind EmpModel generic list using LINQ 
            StdList = (from DataRow dr in dt.Rows

                       select new StudentModel()
                       {
                           StudentId = Convert.ToInt32(dr["Id"]),
                           Name = Convert.ToString(dr["Name"]),
                           DOB = Convert.ToDateTime(dr["DOB"]),
                           CreatedOn = Convert.ToDateTime(dr["CreatedOn"])
                       }).ToList();


            return StdList;


        }
        //To Update Employee details
        public bool UpdateStudent(EmpModel obj)
        {

            connection();
            SqlCommand com = new SqlCommand("UpdateEmpDetails", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@EmpId", obj.Empid);
            com.Parameters.AddWithValue("@Name", obj.Name);
            com.Parameters.AddWithValue("@City", obj.City);
            com.Parameters.AddWithValue("@Address", obj.Address);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }


        }
        //To delete Employee details
        public bool DeleteEmployee(int Id)
        {

            connection();
            SqlCommand com = new SqlCommand("DeleteEmpById", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@EmpId", Id);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }


        }
    }
}
