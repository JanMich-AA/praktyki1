﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie13
{
    internal class RoomWithDoor : Room, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription) : base(name, decoration, hidingPlaceName)
        {
            DoorDescription = doorDescription;
        }
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get;  set; }

        
    }
}
