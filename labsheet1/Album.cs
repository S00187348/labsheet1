using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet1
{
    class album :IComparable<album>
    {
        public string albumName { get; set; }
        public int ReleaseYear { get; set; }
        public int Sales { get; set; }

        public album(string name, int sales, int year)
        {
            albumName = name;
            Sales = sales;
            ReleaseYear = year;

        }

        public override string ToString()
        {
            return $"{albumName}";
        }

        public int CompareTo(album other)
        {
            return this.albumName.CompareTo(other.albumName);
        }
    }
}
