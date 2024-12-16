using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie13
{
    internal class Room : Location
    {
        private string decoration;

        public Room(string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }

        public override String Description
        {
            get
            {
                return base.Description + "Widzisz tutaj " + decoration + ".";
            }
        }
    }
}
