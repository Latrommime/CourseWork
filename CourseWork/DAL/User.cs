﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.DAL
{
   public class User
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }
    }
}
