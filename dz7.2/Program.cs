namespace dz7._2
{
    internal class Program
    {
        abstract class Product
        {
            private double price = 0;
            public double Price
            {
                get { return price; }
                set
                {
                    if (value >= 0) { price = value; }
                    else { throw new Exception("Value cant be lesser than 0"); }
                }
            }

            public Product(double _price) {Price  = _price; }

            public abstract double CalculateDiscount();
        }

        class Electronics : Product
        {
            private int warranty = 0;
            public int Warranty
            {
                get { return warranty; }
                set 
                {
                    if (value >= 0) { warranty = value; }
                    else { throw new Exception("Value cant be lesser than 0"); }
                }
            }
            public Electronics(double _price, int _warranty) : base(_price) { Warranty = _warranty; }

            public override double CalculateDiscount()
            {
                double discount = 0.4 ;
                if (Warranty > 0) { discount /= Warranty; }
                return Price - (Price * discount);
            }
        }

        class Furniture : Product
        {
            private double weight = 0;
            public double Weight
            {
                get { return weight; }
                set
                {
                    if (value >= 0 ) { weight = value; }
                    else { throw new Exception("Value cant be lesser than 0"); }
                }
            }
            public Furniture(double _price, double _weight) : base(_price) { Weight = _weight; }

            public override double CalculateDiscount()
            {
                double discount = Weight / 10.0 * 0.05;
                if (discount > 0.5) {discount = 0.5;}
                return Price - (Price* discount);
            }
        }
        
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Electronics(1280, 12),
                new Furniture(2000, 10),
                new Electronics(3000, 6),
                new Furniture(900, 3.5),
                new Electronics(3000, 0),
                new Furniture(10000, 50)

            };
            foreach (var item in products)
            {
                Console.WriteLine("------------------");
                Console.WriteLine(item.CalculateDiscount());
            }
        }
    }
}
