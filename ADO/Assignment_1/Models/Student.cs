using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1.Models
{
    internal class Student
    {
        public int id {  get; set; }
        public object Id { get; internal set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Grade { get; set; }

    }
}
