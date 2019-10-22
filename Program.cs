using CSharpTraining;

namespace Test
{

    class Program
    {
        static void Main(string[] args)
        {
            Knowlage knowlage = Knowlage.Instance;
            knowlage.SetOutput(new ConsoleOutput());
            //Register Lesson
            knowlage.RegisterLesson(CSharpTraining.lesson1.Inheritence.Instance);
            knowlage.RegisterLesson(CSharpTraining.lesson2.RefOut.Instance);
            knowlage.RegisterLesson(CSharpTraining.lesson3.Initializer.Instance);
            knowlage.RegisterLesson(CSharpTraining.lesson4.Indexer.Instance);
            knowlage.RegisterLesson(CSharpTraining.lesson5.Polymorphism.Instance);
            knowlage.RegisterLesson(CSharpTraining.lesson6.ExtensionMethod.Instance);
            knowlage.RegisterLesson(CSharpTraining.lesson7.WorkWithDelegate.Instance);
            knowlage.RegisterLesson(CSharpTraining.lesson8.Event.Instance);
            knowlage.RegisterLesson(CSharpTraining.lesson9.Tuple.Instance);
            knowlage.RegisterLesson(CSharpTraining.lesson10.OperatorOverloading.Instance);

            //Show lesson Result
            knowlage.PrintResult(CSharpTraining.lesson1.Inheritence.Instance.Key);
            knowlage.PrintResult(CSharpTraining.lesson2.RefOut.Instance.Key);
            knowlage.PrintResult(CSharpTraining.lesson3.Initializer.Instance.Key);
            knowlage.PrintResult(CSharpTraining.lesson4.Indexer.Instance.Key);
            knowlage.PrintResult(CSharpTraining.lesson5.Polymorphism.Instance.Key);
            knowlage.PrintResult(CSharpTraining.lesson6.ExtensionMethod.Instance.Key);
            knowlage.PrintResult(CSharpTraining.lesson7.WorkWithDelegate.Instance.Key);
            knowlage.PrintResult(CSharpTraining.lesson8.Event.Instance.Key);
            knowlage.PrintResult(CSharpTraining.lesson9.Tuple.Instance.Key);
            knowlage.PrintResult(CSharpTraining.lesson10.OperatorOverloading.Instance.Key);
        }
    }
}
