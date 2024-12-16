﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie13
{
    internal class Outside : Location
    {
        public bool hot;

       public Outside(string name, bool hot) : base(name) { this.hot = hot; }

        public override string Description
        {
            get
            {
                string NewDescription = base.Description;
                if (hot)
                    NewDescription += " Tutaj jest bardzo gorąco.";
                return NewDescription;
            }
        }
    }
}
