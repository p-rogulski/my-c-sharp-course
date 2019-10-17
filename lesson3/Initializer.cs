namespace CSharpTraining.lesson3
{
    internal class Person
    {
        public Person(string firstName = "Tomasz", string lastName = "Nowak")
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }
    }

    public class Initializer : ILesson
    {
        private const string _key = "Initializer";

        private static Initializer _instance;
        private Initializer() { }

        public string Key
        {
            get { return _key; }
        }
        public static Initializer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Initializer();
                }
                return _instance;
            }
        }
        public string GetResult()
        {
            Person p1 = new Person();
            Person p2 = new Person(firstName: "Piotr");
            Person p3 = new Person() { LastName = "Kowalski" };


            return $"Person1:{p1.FirstName} {p1.LastName}\nPerson2:{p2.FirstName} {p2.LastName}\nPerson3:{p3.FirstName} {p3.LastName}";

        }
    }
}
