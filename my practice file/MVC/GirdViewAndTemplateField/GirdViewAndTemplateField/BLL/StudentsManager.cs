using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GirdViewAndTemplateField.DAL;

namespace GirdViewAndTemplateField.BLL
{
    public class StudentsManager
    {
        StudentGatway Gatway=new StudentGatway();
        public String saveStudent(Students students)
        {
            if (students.Reg.Length > 4)
            {
                if (Gatway.isRegNoExit(students.Reg)!=null)
                {
                    return "registation number alredy exit";

                }
                else
                {
                    if (Gatway.Save(students) > 0)
                    {
                        return "save succesful";
                    }

                    else
                    {
                        return "Save Failed";
                    }
                    
                }
                
            }
            else
            {
                return "length should be over 4 character";
            }


        }

        public List<Students> GetAlStudentses()
        {
            return Gatway.GetAllStudentses();
        }

        public Students searchstudent(string regNo)
        {
           return Gatway.isRegNoExit(regNo);
        }

        public string updateStudent(Students aStudents)
        {
            int rowaffected=Gatway.UpadteOneStudent(aStudents);

            if (rowaffected > 0)
            {
                return "update succesfully";
            }
            else
            {
                return "update fail";
            }
        }
    }
}