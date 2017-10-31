using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace WebApplication1
{
    [Serializable]
    class Salary
    {
        public decimal basicAmount;
        public decimal medicalPercenatge;

        public decimal convencePercenytage;

        public decimal GetFullAmount()
        {
            medicalPercenatge = basicAmount*(medicalPercenatge/100);
            convencePercenytage = basicAmount*(convencePercenytage/100);
                  return(basicAmount+medicalPercenatge+convencePercenytage);

}
    }
    
}
