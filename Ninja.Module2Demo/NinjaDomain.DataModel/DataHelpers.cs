using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NinjaDomain.Classes;

namespace NinjaDomain.DataModel
{
    class DataHelpers
    {
        public static void NewDbWithSeed()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<NinjaContext>());
            using (var context = new NinjaContext())
            {
                if (context.Ninjas.Any())
                {
                    return;
                }

                var vtClan = context.Clans.Add(new Clan {ClanName = "Vermont Clan"});
                var trutleClan = context.Clans.Add(new Clan { ClanName = "Turtles" });
                var amClan = context.Clans.Add(new Clan { ClanName = "American Ninja Warriors" });
            }
        }
    }
}
