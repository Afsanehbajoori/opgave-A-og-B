using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udvælgelse_af_elementer_fra_lister
{
    class car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }

        public car()
        {

        }

        public car(int i, string m, string b, int y, int p, string c)
        {
            Id = i;
            Model = m;
            Brand = b;
            Year = y;
            Price = p;
            Color = c;
        }


        public override string ToString()
        {
            return $"Id:{Id}  Model: {Model}  Brand :{Brand}  Year: {Year}  Price: {Price}  Color :{Color} ";
        }

    }
}
