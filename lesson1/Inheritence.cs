using System.Text;

namespace CSharpTraining.lesson1
{
    internal class Person
    {
   
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            Age = age;
        }


        public string FirstName
        {
            get;
        }

        public string LastName
        {
            get;
        }

        public int Age
        {
            get;
        }
    }


    internal class Woman : Person
    {    
        public Woman(string firstName, string lastName, int age, string lisptickColor) : base(firstName, lastName, age)
        {
            LipstickColor = lisptickColor;
        }

        public string LipstickColor
        {
            get;
        }

    }


    internal class Man : Person
    {
        public Man(string firstName, string lastName, int age, string beardColor) : base(firstName, lastName, age)
        {
            BeardColor = beardColor;
        }


        public string BeardColor
        {
            get;
        }
    }


    public class Inheritence : ILesson
    {
        private const string _key = "Inheritance";

        private static Inheritence _instance;
        private Inheritence() { }

        public static Inheritence Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Inheritence();
                }
                return _instance;
            }
        }

        public string Key
        {
            get { return _key; }
        }
        public string GetResult()
        {
            Person p1 = new Woman("Anna", "Nowak", 32, "red");
            Person p2 = new Man("Jan", "Kowalski", 42, "black");
            Woman w = (Woman)p1;
            Man m = (Man)p2;

            StringBuilder result = new StringBuilder();

            result.Append("Before Casting:\n");
            result.Append($"Person1: {p1.FirstName} {p1.LastName} {p1.Age} \nPerson2: {p2.FirstName} {p2.LastName} {p2.Age}\n\n");
            result.Append("After up-casting:\n");
            result.Append($"Woman: {w.FirstName} {w.LastName} {w.Age} {w.LipstickColor}\nMan: {m.FirstName} {m.LastName} {m.Age} {m.BeardColor}");
            return result.ToString();
        }
    }
}


