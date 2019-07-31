using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceV2Project {
    public class Service : ICalcSubtotal {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Unit { get; set; }

        public Service (int id, string name, int price, int units) {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Unit = units;
        }
        public string About() {
            return "About Services";
        }

        public decimal notCalcSales() {
            return Price * Unit;
        }
    }
}
