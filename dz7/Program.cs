namespace dz7
{
    internal class Program
    {

        abstract class Device
        {
            public string Name { get; set; } = "Name";

            public Device(string _name) { Name = _name; }

            public abstract void Sound();
            public virtual void Show() { Console.WriteLine($"Device name: {Name}");  }
            public virtual void Desc() { Console.WriteLine($"Device description:"); }
        }

        class Kettle : Device
        {
            private double liters = 0;
            public double Liters
            {
                get { return liters; }
                set
                {
                    if (value >= 1) { liters = value; }
                    else { throw new Exception("Value cant be lesser than 1"); }
                }
            }

            public Kettle(string _name, double _liters) : base(_name) { Liters = _liters; }

            public override void Sound() { Console.WriteLine("*Kettle sound*"); }
            public override void Show() { Console.WriteLine($"Kettle name: {Name}"); }
            public override void Desc() { Console.WriteLine($"{Name} Kettle | Capacity: {Liters}L"); }
        }

        class Microwave : Device
        {
            private int power = 0;
            public int Power
            {
                get { return power; }
                set
                {
                    if (value > 0) { power = value; }
                    else { throw new Exception("Value cant be lesser than 1"); }
                }
            }

            public Microwave(string _name, int _power) : base(_name) { Power = _power; }

            public override void Sound() { Console.WriteLine("*Microwave sound*"); }
            public override void Show() { Console.WriteLine($"Microwave name: {Name}"); }
            public override void Desc() { Console.WriteLine($"{Name} Microwave | Power: {Power}W"); }
        }

        class Car : Device
        {
            private int speed = 0;
            public int Speed
            {
                get { return speed; }
                set
                {
                    if (value > 0) { speed = value; }
                    else { throw new Exception("Value cant be lesser than 1"); }
                }
            }

            public Car(string _name, int _speed) : base(_name) { Speed = _speed; }

            public override void Sound() { Console.WriteLine("*Car sound*"); }
            public override void Show() { Console.WriteLine($"Car name: {Name}"); }
            public override void Desc() { Console.WriteLine($"{Name} Car | Speed: {Speed}km/h"); }
        }

        class Steamboat : Device
        {
            private int speed = 0;
            public int Speed
            {
                get { return speed; }
                set
                {
                    if (value > 0) { speed = value; }
                    else { throw new Exception("Value cant be lesser than 1"); }
                }
            }

            public Steamboat(string _name, int _speed) : base(_name) { Speed = _speed; }

            public override void Sound() { Console.WriteLine("*Steamboat sound*"); }
            public override void Show() { Console.WriteLine($"Steamboat name: {Name}"); }
            public override void Desc() { Console.WriteLine($"{Name} Steamboat | Speed: {Speed}km/h"); }
        }
        static void Main(string[] args)
        {
            Device[] devices = new Device[] {
                new Kettle("Kettle1", 2.5),
                new Microwave("Microwave 2", 800),
                new Car("Car3", 150),
                new Steamboat("Steamboat4", 75),
            };
            foreach (var item in devices)
            {
                Console.WriteLine("--------------------------");
                item.Show();
                item.Desc();
                item.Sound();
            }
        }
    }
}
 