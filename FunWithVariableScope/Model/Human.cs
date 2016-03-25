using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Human
    {
        [JsonProperty (PropertyName = "FirstName")]
        public string FirstName { get; set; }
        [JsonProperty (PropertyName = "LastName")]
        public string LastName { get; set; }
        [JsonProperty]
        public string FullName { get { return this.FirstName + " " + this.LastName; } }
    }
}
