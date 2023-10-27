﻿using Project.ENTİTİES.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class DoktorHemsireMap : BaseMap<DoktorHemsire>
    {
        public DoktorHemsireMap()
        {
            Ignore(x => x.ID);
            HasKey(x => new
            { 
            x.DoktorID,
            x.HemsireID
            });
        }
    }
}
