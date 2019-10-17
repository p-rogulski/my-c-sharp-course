namespace CSharpTraining.lesson5
{
    internal struct Edge
    {
        int from;
        int to;
    }


    internal abstract class Graph
    {
        public abstract void AddEdge(Edge edge);
        public abstract void RemoveEdge(Edge edge);

        public virtual string GetName()
        {
            return "Graph";
        }


    }

    internal class MatrixGraph : Graph
    {
        public override void AddEdge(Edge edge)
        {

        }
        public override void RemoveEdge(Edge edge)
        {

        }

        public override string GetName()
        {
            return $"Matrix{base.GetName()}";
        }
    }

    internal class ListGraph : Graph
    {

        public override void AddEdge(Edge edge)
        {

        }
        public override void RemoveEdge(Edge edge)
        {

        }

        public override string GetName()
        {
            return $"List{base.GetName()}";
        }
    }

    public class Polymorphism : ILesson
    {
        private const string _key = "Polymorphism";

        private static Polymorphism _instance;
        public Polymorphism() { }
        public string Key
        {
            get { return _key; }
        }
        public static Polymorphism Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Polymorphism();
                }
                return _instance;
            }
        }
        public string GetResult()
        {

            Graph graph1 = new ListGraph();
            Graph graph2 = new MatrixGraph();

            return $"Graph1: {graph1.GetName()}\nGraph2: {graph2.GetName()}";
        }
    }
}
