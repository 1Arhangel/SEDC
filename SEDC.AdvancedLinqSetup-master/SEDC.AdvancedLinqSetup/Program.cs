using Newtonsoft.Json;
using SEDC.AdvancedLinqSetup.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SEDC.AdvancedLinqSetup
{


    class Program
    {
        static void Main()
        {
            Utils.InitData();

            Console.WriteLine("NUMBER OF USERS "+DataContext.Users.Count());

            var neprazenMejl = DataContext.Users.Select(x => x.email != " ").ToList();
            Console.WriteLine("NUMBER OF USERS " + DataContext.Users.Count(x=>x.email == ""));
            var userIdIsBiggerThanFive = DataContext.Users.Count(x => x.id > 5);
            
            Console.WriteLine("Neprazen Mejl imaat "+neprazenMejl.Count+" useri");
            //Console.ReadLine();

            var listOfUserNames = DataContext.Users.Select(x => x.name).ToList();

            for (int i = 0; i < listOfUserNames.Count; i++)
            {
                var username = listOfUserNames[i];
                Console.WriteLine(username);
            }


            // TODO user name of user so id 5

            string deciamlSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            //TODO user name of user so id 117

            //usernames of users that live between coords -37 and -45
            var userNames = DataContext.Users.Where(x => Convert.ToDouble(x.address.geo.lat.Replace(".",deciamlSeparator)) > -45.00 && Convert.ToDouble(x.address.geo.lat.Replace(".", deciamlSeparator)) < -37.00).ToList();
            
            //var x = DataContext.Users;
            
            Console.ReadLine();
        }

      
        

    }
}
