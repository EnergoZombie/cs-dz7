namespace dz7._1
{
    internal class Program
    {
        class Course
        {
            private int duration = 0;
            public int Duration
            {
                get { return duration; }
                set
                {
                    if (value > 0) { duration = value; }
                    else { throw new Exception("Value cant be lesset than 1"); }
                }
            }
            public string Name { get; set; } = "Name";

            public Course(string _name, int _duration) { Name = _name; Duration = _duration; }

            public override string ToString() { return $"Course \"{Name}\" | {Duration} hours"; }
        }

        class OnlineCourse : Course
        {
            public string Platform { get; set; } = "Platform";

            public OnlineCourse(string _name, int _duration, string _platform) : base(_name, _duration) { Platform = _platform; }

            public override string ToString() { return $"Course \"{Name}\" | {Duration} hours | Platform: {Platform}"; }
        }
        static void Main(string[] args)
        {
            Course c = new Course("c1", 3);
            OnlineCourse o = new OnlineCourse("c2", 3, "p2");
            Console.WriteLine(c);
            Console.WriteLine(o);
        }
    }
}
