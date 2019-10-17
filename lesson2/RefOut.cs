using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining.lesson2
{
    public class RefOut : ILesson
    {
        private const string _key = "RefOut";

        private static RefOut _instance;
        public RefOut() { }

        public string Key
        {
            get { return _key; }
        }

        public static RefOut Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RefOut();
                }
                return _instance;
            }
        }

        private string MethodWithRef(ref string a)
        {
            a = a + 's';
            return a;
        }

        private int MethodWithOut(out int b)
        {
            b = 1;
            return ++b;
        }

        public string GetResult()
        {
            int myOut;//cannot be nitialized before
            string myRef = "REF";//must be initialized before

            MethodWithOut(out myOut);
            MethodWithRef(ref myRef);

            return $"My out after call: {myOut}\nMy ref after call: {myRef}";

        }
    }
}
