using System;
using System.Collections.Generic;

namespace CSharpTraining
{
    public class Knowlage
    {
        private Dictionary<string,ILesson> _lessons;
        private static Knowlage _instance;
        private IOutput _output;
        private Knowlage()
        {
            _lessons = new Dictionary<string,ILesson>();
        }

        public void SetOutput(IOutput output)
        {
            _output = output;
        }

        public static Knowlage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Knowlage();
                }
                return _instance;
            }
        }

        public void RegisterLesson(ILesson lesson)
        {
            _lessons.Add(lesson.Key, lesson);
        }

        public void PrintResult(string lessonName)
        {
                var lesson = _lessons[lessonName];
                _output.PrintResult($"[{lesson.Key}]\n[RESULT]\n{lesson.GetResult()}\n");
        }

    }
}
