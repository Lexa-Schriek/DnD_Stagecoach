using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StagecoachApp
{
    class UpgradeModel : ItemModel
    {
        override public Boolean IsUpgrade
        {
            get { return true; }
        }
        public int EquippedSlot { get; set; }
    }
}
