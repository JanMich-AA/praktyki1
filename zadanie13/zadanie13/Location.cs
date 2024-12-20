﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie13
{
    internal class Location
    {
        public Location(string name)
        {
            name = name;
        }
        public Location[] Exits;
        public string Name { get; private set; }

        public virtual string Description
        {
            get
            {
                string description = "Stoisz w " + Name + ". Widzisz wyjścia do następujących lokacji";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if(i != Exits.Length - 1)
                        description += ",";
                }
                description += ".";
                return description;
            }
        }
    }
}
