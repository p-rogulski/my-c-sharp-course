using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTraining
{
    public interface ILesson
    {
        string Key{ get; }
        string GetResult();
    }
}
