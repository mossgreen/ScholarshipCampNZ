using System;
using System.Collections.Generic;
using NinjaDomain.Classes;
using System.ComponentModel.DataAnnotations;

namespace NinjaDomain.Classes
{
   public class Ninja
    {
        public Ninja()
        {
            EquipmentOwned = new List<NinjaEquipment>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool ServedInOniwaban { get; set; }
        public Clan Clan { get; set; }
        public int ClanId { get; set; }
        public List<NinjaEquipment> EquipmentOwned { get; set; }
    }

    public class Clan
    {

        public Clan()
        {
            Ninjas = new List<Ninja>();
        }
        public int Id  { get; set; }
        public String ClanName { get; set; }
        public List<Ninja> Ninjas { get; set; }
    }

    public class NinjaEquipment
    {/*
        a note about lack of foreign key properties
         */
        public int Id { get; set; }
        public string Name  { get; set; }
        public EquipmentType Type { get; set; }
        [Required]
        public Ninja Ninja { get; set; }
    }
}
