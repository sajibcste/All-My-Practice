using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using webFirst.DAL.MODEL;


namespace webFirst.DAL.GATWAY
{
    public class StudentGatway
    { 
        string connectionstring = "server=PC-NET;Database=UniversityManagmentSystem;Integrated Security =True ";
        public int Add(Student aStudent)
        {
           
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "insert into Students values('" + aStudent.Registation + "','" + aStudent.Name + "','" +aStudent.Email + "','" + aStudent.Contact + "','" + aStudent.Department + "')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int row = command.ExecuteNonQuery();
            return row;
        }

        public Student IsRegExit(string reg)
        {
            SqlConnection connection=new SqlConnection(connectionstring);
            string query = "select * from Students where Reg='" + reg + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

           SqlDataReader reader = command.ExecuteReader();
            Student student = null;

            if (reader.HasRows)
            {
                reader.Read();
                student = new Student();
                student.id = Convert.ToInt16(reader["id"]);
                student.Registation = reader["Reg"].ToString();
                student.Name = reader["Name"].ToString();
                student.Email = reader["Email"].ToString();
                student.Contact = reader["Contact"].ToString();
                student.Department = reader["Department"].ToString();
            }
            connection.Close();
            reader.Close();
            return student;

        }

     public   List<Student> GetAllStudents()
        {

            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "select * from Students";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Student>students=new List<Student>();
            while (reader.Read())
            {
                Student aStudent=new Student();
                aStudent.id = Convert.ToInt16(reader["id"]);
                aStudent.Registation = reader["Reg"].ToString();
                aStudent.Name = reader["Name"].ToString();
                aStudent.Email = reader["Email"].ToString();
                aStudent.Contact = reader["Contact"].ToString();
                aStudent.Department = reader["Department"].ToString();
                students.Add(aStudent);


            }
         connection.Close();
         reader.Close();
            return students;


        }


        public int update(Student aStudent)
        {
           SqlConnection connection=new SqlConnection(connectionstring);
            string query = "update students set Reg='"+aStudent.Registation+"',Name='"+aStudent.Name+"',Email='"+aStudent.Email+"',Contact='"+aStudent.Contact+"',Department='"+aStudent.Department+"' where id="+aStudent.id;
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
         int row= command.ExecuteNonQuery();
            connection.Close();
            return row;
        }

        public int Delete(int id)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "delete from students where id="+ id;
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            int row = command.ExecuteNonQuery();
            return row;
        }

       public  Student GetAllStudentsByid(int id)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "select * from Students where id="+id;
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            Student student = null;

            if (reader.HasRows)
            {
                reader.Read();
                student = new Student();
                student.id = Convert.ToInt16(reader["id"]);
                student.Registation = reader["Reg"].ToString();
                student.Name = reader["Name"].ToString();
                student.Email = reader["Email"].ToString();
                student.Contact = reader["Contact"].ToString();
                student.Department = reader["Department"].ToString();
            }
            connection.Close();
            reader.Close();
            return student;

        

        }
    }
}