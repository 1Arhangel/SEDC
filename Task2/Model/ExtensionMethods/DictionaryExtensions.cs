using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ExtensionMethods
{
    public static class DictionaryExtensions
    {

        public static void AddWord(this Dictionary<string, string>dictionary, string param1, string param2)
        {
           dictionary.Add(param1, param2);
        }

        public static void RemoveWord(this Dictionary<string, string>dictionary, string param1)
        {
            dictionary.Remove(param1);
        }

        public static bool ContainsKeyOrValue(this Dictionary<string,string>dictionary, string param1)
        {
            if (dictionary.ContainsKey(param1) || dictionary.ContainsValue(param1))
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
