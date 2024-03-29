﻿using System;
using System.Collections.Generic;

namespace CSharpTraining
{
    public class Knowledge
    {
        private Dictionary<string,ILesson> _lessons;
        private static Knowledge _instance;
        private IOutput _output;
        private Knowledge()
        {
            _lessons = new Dictionary<string,ILesson>();
        }

        public void SetOutput(IOutput output)
        {
            _output = output;
        }

        public static Knowledge Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Knowledge();
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
