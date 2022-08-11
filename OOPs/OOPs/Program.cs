namespace OOPs
{
    internal class DemoEncap
    {

        private String studentName;
        private int studentAge;
        public String Name
        {

            get
            {
                return studentName;
            }

            set
            {
                studentName = value;
            }

        }

        public int Age
        {

            get
            {
                return studentAge;
            }

            set
            {
                studentAge = value;
            }

        }
        static void Main(string[] args)
        {
            DemoEncap obj = new DemoEncap();
            obj.Name = "Likitha";
            obj.Age = 21;
            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Age);
        }
    }
}