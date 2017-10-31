using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webFirst.DAL.GATWAY;
using webFirst.DAL.MODEL;

namespace webFirst.BLL
{
    public class StudentManager
    {
          StudentGatway aStudentGatway=new StudentGatway();
        public string Add(Student aStudent)
        {
            if (aStudent.Registation.Length > 6)
            {
                if (aStudentGatway.IsRegExit(aStudent.Registation)!=null)
                {
                    return "Registation number already exit";
                } 
                else
                {
                    if (aStudentGatway.Add(aStudent) > 0) 
                {
                    return "DataSaved successfully";
                }
            else
                {

                    return "data are not saved";
                }
                }
            }

                
           
            else
            {
                return "registation no atlest 6 character";
            }
            
        }

        

       public List<Student> GetAllStudents()
       {
         return  aStudentGatway.GetAllStudents();
       }


        public  Student Search(string reg)
        {
            return aStudentGatway.IsRegExit(reg);
        }

        public string update(Student aStudent)
        {
            int row= aStudentGatway.update(aStudent);
            if (row > 0)
            {

                return "update success";
            }
            else
            {
                return "update failed";
            }
        }

        public string Delete(int id)
        {
            int rowaffcted = aStudentGatway.Delete(id);
            if (rowaffcted > 0)
            {
                return "delte succesful";
            }
            else
            {
                return " delete failed";
            }
        }

        public Student GetAllStudentsById(int id)
        {
            return aStudentGatway.GetAllStudentsByid(id);
        }
    }
}