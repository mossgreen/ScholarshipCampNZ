using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperAPIDemo.Properties.Models
{
    public class HeroGenerator
    {
        public static string GetHeroName(string firstName, string lastName)
        {
            var f = firstName.Substring(0, 1);
            var l = lastName.Substring(0, 1);

            return "moss's getname"+ firstName+"haha"+lastName;
        }
    }
}
