using System;
namespace StagecoachApp
{
    public class UpgradeModel : ItemModel
    {
        override public Boolean IsUpgrade
        {
            get { return true; }
        }
        public int EquippedSlot { get; set; }
    }
}
