namespace StaticRecap
{
    public class Developer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static int  NumberOfDeveloper { get; set; }
        public Developer(string firstName, string lastName, int age)
        {
            
        }
    }
}