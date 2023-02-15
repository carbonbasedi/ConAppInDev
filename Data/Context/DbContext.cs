﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Context
{
    public static class DbContext
    {
        static DbContext()
        {
            Groups = new List<Group>();
        }
        public static List<Group> Groups { get; set; }
    }
}
