using System;
using System.Collections.Generic;
namespace CSharpTraining.lesson7
{
    public delegate int SimplateDelagate(string s);
    public delegate TResult GenericDelegate<in T, out TResult>(T o);
    public class WorkWithDelegate : ILesson
    {
        public const string _key = "Delegate";
        private static WorkWithDelegate _instance;
        private List<int> _results;
        private Action<int, int> _mathOperations;
        private WorkWithDelegate()
        {
            _mathOperations += _add;
            _mathOperations += _sub;
            _results = new List<int>();
        }

        public string Key
        {
            get { return _key; }
        }

        public static WorkWithDelegate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WorkWithDelegate();
                }
                return _instance;
            }
        }



        private void _add(int a, int b)
        {
            _results.Add(a + b);
        }

        private void _sub(int a, int b)
        {
            _results.Add(a - b);
        }

        public string GetResult()
        {
            string results = "";
            _mathOperations(20, 30);
            _results.ForEach((result) => results += $"{"(" + _results.IndexOf(result).ToString() + ")=>" + result} ");
            return $"Result from Func<int,int,int> => _mathOperations: {results}";
        }
    }
}
