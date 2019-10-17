using System;

namespace CSharpTraining.lesson4{
    internal class DataSet
    {
        private string [] _data;
        public DataSet()
        {
            _data = new string[5] { "a", "b", "c", "d", "e"};
        }

        public char this[int index]{
            get
            {
                return Convert.ToChar(_data[index]);
            }

            set
            {
                _data[index] = value.ToString();
            }
        }
    }
    public class Indexer : ILesson
    {
        public const string _key = "Indexer";

        private static Indexer _instance;
        private Indexer() { }

        public string Key
        {
            get { return _key; }
        }

        public static Indexer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Indexer();
                }
                return _instance;
            }
        }

        public string GetResult()
        {
            DataSet dataSet = new DataSet();
            return $"{dataSet[0]},{dataSet[1]},{dataSet[2]},{dataSet[3]},{dataSet[4]}";
        }
    }
}
