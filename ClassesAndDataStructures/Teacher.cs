using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndDataStructures
{
    internal class Teacher
    {
        public required string Name { get; set; } //quando usi zucc. sint. con le graffe ci sta usare required
        public string? Surname { get; set; }
        public string? Subject { get; set; }
    }
}
