using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public sealed class Teacher:SEDCMember
    {
        public Teacher(string Id, string FirstName, string LastName)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;

        }

        public override string GetDetails()
        {
            return this.FirstName + this.LastName + this.Id;
        }
    }
}
