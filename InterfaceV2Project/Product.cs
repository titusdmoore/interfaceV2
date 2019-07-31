using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceV2Project {
    public class Product : ICalcSubtotal {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Units { get; set; }

        public Product (int id, string name, decimal price, int unit) {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Units = unit;
        }

        public string About () {
            return "About Products";
        }

        public decimal notCalcSales() {
            return Price * Units;
        }
    }
}
