namespace CSharpTraining.lesson6
{
    internal static class StringAddHash
    {
        public static string AppendHash(this string input)
        {
            return $"{input}#";
        }
    }
    public class ExtensionMethod : ILesson
    {
        private const string _key = "ExtensionMethod";
        private static ExtensionMethod _instance;
        private ExtensionMethod() { }
        public string Key
        {
            get { return _key; }
        }
        public static ExtensionMethod Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ExtensionMethod();
                }
                return _instance;
            }
        }

        public string GetResult()
        {
            const string example = "C";
            return $"Before Extension Method (AppendHash) - simple string: {example}\nResult from Extension Method (AppendHash): {example.AppendHash()}";
        }
    }
}
