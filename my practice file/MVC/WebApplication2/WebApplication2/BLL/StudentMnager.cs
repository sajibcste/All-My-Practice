using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.DAL.Gatway;

namespace WebApplication2.BLL
{
    public class StudentMnager
    {
        StudentGatway agGatway=new StudentGatway();
        public  string Save(DAL.Model.Student astudent)
        {
            if (astudent.Reg.Length > 6)
            {
                if (agGatway.isExit(astudent.Reg))
                {
                    return "Registation number already exixt";
                }
                else
                {
                    if (agGatway.StudentEntry(astudent) > 0)
                    {
                        return "save succesfull";

                    }
                    else
                    {
                        return "save unsuccesfull";
                    }
                }
            }

            else
            {
                return "Registation number should be 6 chaeacter long";
            }

        }
    }
}