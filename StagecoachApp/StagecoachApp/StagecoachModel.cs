using System.ComponentModel.DataAnnotations;

namespace StagecoachApp
{
    public class StagecoachModel
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int HitPointsMax { get; set; }
        public int Horses { get; set; }
        public int Rations { get; set; }
        public int Water { get; set; }
        public int CrewCount { get; set; }
        public int UpgradeSlots
        {
            get
            {
                return Horses;
            }
        }
        public int WeightCapacity
        {
            get
            {
                return (300 + 100 * Horses);
            }
        }
        public string DisplayName
        {
            get
            {
                return Name + ", crew: " + CrewCount + ", horses: " + Horses;
            }
        }

    }
}