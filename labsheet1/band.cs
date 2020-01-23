using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet1
{
    class band : IComparable<band>
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Members{ get; set; }

        public band(string name, string members, int year)
        {
             Name = name;
            Members = members;
            Year =year;

        }

        public override string ToString()
        {
            return $"{Name}";
        }

        public int CompareTo(band other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
