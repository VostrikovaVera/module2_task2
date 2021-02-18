using Module2Task2.Enums;
using System;

namespace Module2Task2.Entities
{
    class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public Currency Currency { get; set; }

        public MeasureUnits MeasureUnit { get; set; }

        public Countries CountryOfOrigin { get; set; }
    }
}
