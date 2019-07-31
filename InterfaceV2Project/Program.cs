using System;

namespace InterfaceV2Project {
    class Program {
        static void Main(string[] args) {

            var p1 = new Product(1, "Basic Widget", 10m, 2500);
            var p2 = new Product(2, "Advanced Widget", 25m, 1500);
            var p3 = new Product(3, "Supreme Widget", 50m, 1000);

            var s1 = new Service(4, "Basic Service", 25, 1000);
            var s2 = new Service(5, "Priority Support", 50, 550);
            var s3 = new Service(6, "24x7 Support", 100, 750);


            var m1 = new Membership(7, "Basic", 100, 1500);
            var m2 = new Membership(8, "Advanced", 200, 700);
            var m3 = new Membership(9, "Premiere", 400, 300);

            //var products = new Product[] { p1, p2, p3 };
            //var services = new Service[] { s1, s2, s3 };

            var PandS = new ICalcSubtotal[] { p1, p2, p3, s1, s2, s3, m1, m2, m3 };

            decimal total = 0m;

            foreach (var pors in PandS) {
                total += pors.notCalcSales();
            }

            //foreach (var prod in PandS) {
            //    total += prod.notCalcSales();
            //}

            //foreach (var serv in services) {
            //    total += serv.notCalcSales();
            //}
            Console.WriteLine($"Grand total is ${total}");
        }
    }
}
