﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Personel
    {
        [DisplayName("شماره پرونده")]

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NumericalNumber { get; set; }
        public string Name { get { return FirstName + " " + LastName;}

        }
    }
}
