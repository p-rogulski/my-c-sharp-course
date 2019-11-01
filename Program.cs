using CSharpTraining;

namespace Test
{

    class Program
    {
        static void Main(string[] args)
        {
            Knowledge Knowledge = Knowledge.Instance;
            Knowledge.SetOutput(new ConsoleOutput());
            //Register Lesson
            Knowledge.RegisterLesson(CSharpTraining.lesson1.Inheritence.Instance);
            Knowledge.RegisterLesson(CSharpTraining.lesson2.RefOut.Instance);
            Knowledge.RegisterLesson(CSharpTraining.lesson3.Initializer.Instance);
            Knowledge.RegisterLesson(CSharpTraining.lesson4.Indexer.Instance);
            Knowledge.RegisterLesson(CSharpTraining.lesson5.Polymorphism.Instance);
            Knowledge.RegisterLesson(CSharpTraining.lesson6.ExtensionMethod.Instance);
            Knowledge.RegisterLesson(CSharpTraining.lesson7.WorkWithDelegate.Instance);
            Knowledge.RegisterLesson(CSharpTraining.lesson8.Event.Instance);
            Knowledge.RegisterLesson(CSharpTraining.lesson9.Tuple.Instance);
            Knowledge.RegisterLesson(CSharpTraining.lesson10.OperatorOverloading.Instance);

            //Show lesson Result
            Knowledge.PrintResult(CSharpTraining.lesson1.Inheritence.Instance.Key);
            Knowledge.PrintResult(CSharpTraining.lesson2.RefOut.Instance.Key);
            Knowledge.PrintResult(CSharpTraining.lesson3.Initializer.Instance.Key);
            Knowledge.PrintResult(CSharpTraining.lesson4.Indexer.Instance.Key);
            Knowledge.PrintResult(CSharpTraining.lesson5.Polymorphism.Instance.Key);
            Knowledge.PrintResult(CSharpTraining.lesson6.ExtensionMethod.Instance.Key);
            Knowledge.PrintResult(CSharpTraining.lesson7.WorkWithDelegate.Instance.Key);
            Knowledge.PrintResult(CSharpTraining.lesson8.Event.Instance.Key);
            Knowledge.PrintResult(CSharpTraining.lesson9.Tuple.Instance.Key);
            Knowledge.PrintResult(CSharpTraining.lesson10.OperatorOverloading.Instance.Key);
        }
    }
}
