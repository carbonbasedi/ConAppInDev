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
            Students = new List<Student>();
            WorkForce = new List<Personnel>();
        }
        public static List<Group> Groups { get; set; }
        public static List<Student> Students { get; set;}
        public static List<Personnel> WorkForce { get; set; }
    }
}
