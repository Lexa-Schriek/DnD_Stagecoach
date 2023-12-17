using System.ComponentModel.DataAnnotations;
using System;

namespace StagecoachApp
{
    public class ActionModel
    {
        [Key]
        public int Id { get; set; }
        public int UpgradeId { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public Boolean UsesAmmo { get; set; }
        public int AmmoId { get; set; }
        public int AmmoUsed { get; set; }
        public string Name { get; set; }
    }
}
