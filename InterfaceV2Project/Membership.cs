using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceV2Project {
    public class Membership : ICalcSubtotal {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Duration { get; set; }

        public Membership(int id, string name, int price, int duration) {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Duration = duration;
        }

        public decimal notCalcSales() {
            return Price * Duration;
        }
    }
}
