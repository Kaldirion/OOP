﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsClass
{
    public class PropertyChanged : EventArgs
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string OldName { get; set; }
        public int OldAge { get; set; }
        public string ChangedProperty { get; set; }
    }
}
