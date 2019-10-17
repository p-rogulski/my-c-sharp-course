namespace CSharpTraining.lesson9
{
    public class Tuple : ILesson
    {
        private const string _key = "Tuple";

        private static Tuple _instance;
        public Tuple() { }

        public string Key
        {
            get { return _key; }
        }

        public static Tuple Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Tuple();
                }
                return _instance;
            }
        }

        public string GetResult()
        {
            var person1 = ("John", 33);// With anonymus type
            (string, int) person2 = ("Bob", 23);// With specific types
            //Type Matching. Potentialy could be problematic like in this case int Age => string Age
            (string Name, int Age, char Sex) person3 = ("Bartek", 23, 'M');
            (string Age, int Sex, char Name) person4 = person3;
            // With anonymous type and explicit field name
            var person5 = (Name:"Bartek", Age:23);
            //Tuple deconstruction
            (string Name, int Age) = person5;
            //Types inferention
            (string, int, char) GetBob() => ("Param1", 2, 'C');
            var (param1, param2, param3) = GetBob();

            return $"Person1:\nFirstName: {person1.Item1} Age: {person1.Item2}\n" +
                $"Person2:\nFirstName: {person2.Item1} Age: {person2.Item2}\n" +
                $"Person3:\nFirstName: {person3.Name} Age: {person3.Age} Sex: {person3.Sex}\n" +
                $"Person4 (Broken matching with person3):\nFirstName: {person4.Name} Age: {person4.Age} Sex: {person3.Sex}\n" +
                $"Person5:\nFirstName: {person5.Name} Age: {person5.Age}\n" +
                $"Person5 (Tuple deconstruction):\nFirstName: {Name} Age: {Age}\n" +
                $"Types inferention:\nparam1: {param1} param2: {param2} param3: {param3}";

        }
    }
}
