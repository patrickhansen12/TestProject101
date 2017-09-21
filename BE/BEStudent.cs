using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class BEStudent
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public String Tlf { get; set; }
        public BEGroup Group { get; set; }
    }
}
