using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace GirdViewAndTemplateField.DAL
{
    public class StudentGatway:MainGatway
    {

        public int Save(Students astudent)
        {
           // connection = new SqlConnection(connectionstring);
            query = "insert into Students(Name,Reg,Email,contact,DepartmentId)  values('" + astudent.Name + "','" + astudent.Reg + "','" + astudent.Email + "','" + astudent.Contact + "','" + astudent.DepartmentId + "')"; 
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
            
        }

        public Students isRegNoExit(string reg)
        {
           // SqlConnection connection=new SqlConnection(connectionstring);
            string query = "select * from  Students where Reg='"+reg+"' ";
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
             reader=command.ExecuteReader();
            Students aStudent = null;
            

            if(reader.HasRows)

            {
                reader.Read();
                aStudent=new Students();
                aStudent.id = Convert.ToInt16(reader["Id"]);
                aStudent.Reg = reader["Reg"].ToString();
                aStudent.Name = reader["Name"].ToString();
                aStudent.Reg = reader["Reg"].ToString();
                aStudent.Email = reader["Email"].ToString();
                aStudent.Contact = reader["contact"].ToString();
 }
            reader.Close();
            connection.Close();
            return aStudent;


        }

        public List<Students> GetAllStudentses()
        {
           // SqlConnection connection=new SqlConnection(connectionstring);
            string query = "select *  from Students ";

            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
             reader = command.ExecuteReader();
            List<Students> students=new List<Students>();


            while (reader.Read())
            {
                Students student=new Students();
                student.id = Convert.ToInt32(reader["Id"]);
                student.Name = reader["Name"].ToString();
                student.Reg = reader["Reg"].ToString();
                student.Email = reader["Email"].ToString(); 
                student.Contact = reader["contact"].ToString();
                students.Add(student);

            }
            reader.Close();
            connection.Close();
            
            return students;
        }


        public int UpadteOneStudent(Students aStudents)
        {
          //  SqlConnection connection=new SqlConnection(connectionstring);
            string query = "update  Students set Name='"+aStudents.Name+"',Email='"+aStudents.Email+"',Contact='"+aStudents.Contact+"' where Id="+aStudents.id;
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            int rowafffect = command.ExecuteNonQuery();
            connection.Close();
            return rowafffect;
        }
    }
}