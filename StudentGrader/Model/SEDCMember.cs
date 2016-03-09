using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class SEDCMember
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        

        public abstract string GetDetails();
        
        public static bool ScanIdCard(string Id)
        {
            if (Id == null)
            {
                return false;
            }
            else if(Id == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool IsIdValid(string Id)
        {
            int result;

            bool isItValid = int.TryParse(Id, out result);

            if (isItValid)
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
