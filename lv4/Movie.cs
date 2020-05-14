using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv4
{
    class Movie : IRentable
    {
        private readonly double BaseMoviePrice = 9.99;
        public String Name { get; private set; }
        public Movie(String name) { this.Name = name; }
        public string Description { get { return this.Name; } }
        public double CalculatePrice() { return BaseMoviePrice; }

    }
}
