using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSHocSinh.Entities
{
    internal class HocSinh
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public HocSinh(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString() => $"{Id} | {Name} | {Age}";
    }
}
