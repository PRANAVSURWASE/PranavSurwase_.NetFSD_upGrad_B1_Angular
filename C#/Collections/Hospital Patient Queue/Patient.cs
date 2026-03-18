using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Patient_Queue
{
    internal class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Disease {  get; set; }

        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, Disease:{Disease}";
        }
    }
}
