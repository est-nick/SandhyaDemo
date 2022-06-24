﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SandhyaDemo.DbModels
{
    public class Fruit
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string UniqueFruitRef 
        { 
            get { return Name + "0000" + Id; }
        }
    }
}
