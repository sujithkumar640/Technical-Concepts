using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
namespace Webservice
{
    /// <summary>
    /// Summary description for StudentWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class StudentWebService : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        // here student is object
        //public Student GetStudentById()
        //{
        //    int ID = 1;
        //    string cs = ConfigurationManager.ConnectionStrings["cdkConnectionString"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(cs))
        //    {
        //        SqlCommand cmd = new SqlCommand("spGetStudentByID", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        SqlParameter parameter = new SqlParameter("@ID", ID);
        //        cmd.Parameters.Add(parameter);
        //        Student student = new Student();
        //        con.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            student.ID = Convert.ToInt32(reader["ID"]);
        //            student.Name = reader["Name"].ToString();
        //            student.Gender = reader["Gender"].ToString();
        //            student.TotalMarks = Convert.ToInt32(reader["TotalMarks"]);
                
        //        }
        //        //JavaScriptSerializer oSerializer = new JavaScriptSerializer();
        //        //string sJSON = oSerializer.Serialize(student);
        //        return student;

        //    }
        //}
        public Student GetStudentById(int ID)
        {
            string cs = @"Data Source=HYD-DEHARISH-L;Initial Catalog=cdk;Integrated Security=True";
            using (cdkDataContext cdkDb = new cdkDataContext(cs))
            {
                Student student = new Student();
                var query_equals1 = from c in cdkDb.tblStudents
                                    where c.ID.Equals(ID)
                                    select new
                                    {
                                        c.Name,
                                        c.Gender,
                                        c.TotalMarks,
                                        c.ID
                                    };
                foreach (var c in query_equals1)
                {
                    student.ID = Convert.ToInt32(c.ID);
                    student.Name = c.Name.ToString();
                    student.Gender = c.Gender.ToString();
                    student.TotalMarks = Convert.ToInt32(c.TotalMarks);
                }
                return student;
            }
            
            //string cs = ConfigurationManager.ConnectionStrings["cdkConnectionString"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(cs))
            //{
            //    SqlCommand cmd = new SqlCommand("spGetStudentByID", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    SqlParameter parameter = new SqlParameter("@ID", ID);
            //    cmd.Parameters.Add(parameter);
            //    Student student = new Student();
            //    con.Open();
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        student.ID = Convert.ToInt32(reader["ID"]);
            //        student.Name = reader["Name"].ToString();
            //        student.Gender = reader["Gender"].ToString();
            //        student.TotalMarks = Convert.ToInt32(reader["TotalMarks"]);

            //    }
            //    //JavaScriptSerializer oSerializer = new JavaScriptSerializer();
            //    //string sJSON = oSerializer.Serialize(student);
            //    return student;

            //}
        }
        [WebMethod]
        public string GetDateTime()
        {
            return DateTime.Now.ToString();
        }
        
    }
}
