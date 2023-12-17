using System;
using System.ComponentModel.DataAnnotations;


namespace StagecoachApp
{
    public class ItemModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public int Weight { get; set; }
        virtual public Boolean IsUpgrade
        {
            get { return false; }
        }
        public string DisplayName
        {
            get { return Name + " Weight: " + Weight + " Value: " + Value; }
        }
    }
}
