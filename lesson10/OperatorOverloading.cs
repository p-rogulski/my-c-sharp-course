using System.Text;

namespace CSharpTraining.lesson10
{
    internal class Distance
    {
        public float Value { get; set; }
        public Distance(float value)
        {
            Value = value;
        }

        public static implicit operator Distance(Road r)
        {
            return new Distance(r.Length);
        }
    }


    internal class Road
    {
        public float Length { get; }

        public Road(float length)
        {
            Length = length;
        }

        public static Road operator +(Road r1, Road r2)
        {
            return new Road(r1.Length + r2.Length);
        }

        public static Road operator -(Road r1, Road r2)
        {
            return new Road(r1.Length + r2.Length);
        }

        public static Road operator *(Road r1, Road r2)
        {
            return new Road(r1.Length * r2.Length);
        }

        public static Road operator /(Road r1, Road r2)
        {
            return new Road(r1.Length / r2.Length);
        }

        public static bool operator ==(Road r1, Road r2)
        {
            return r1.Length == r2.Length;
        }

        public static bool operator !=(Road r1, Road r2)
        {
            return r1.Length != r2.Length;
        }

        public static explicit operator Road(Distance d)
        {
            return new Road(d.Value);
        }

    }


    class OperatorOverloading : ILesson
    {
        private const string _key = "OperatorOverloading";

        private static OperatorOverloading _instance;
        public OperatorOverloading() { }

        public string Key
        {
            get { return _key; }
        }

        public static OperatorOverloading Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OperatorOverloading();
                }
                return _instance;
            }
        }

        public string GetResult()
        {
            Road road1 = new Road(20.2F);
            Road road2 = new Road(12.5F);
            Road road3 = new Road(20.1F);
            Distance distance = new Distance(20.3F);

            StringBuilder result = new StringBuilder("Road r1=20.2 r2=12.5 - calculation results:\n");

            result.Append($"operator + : {(road1 + road2).Length}\n");
            result.Append($"operator - : {(road1 - road2).Length}\n");
            result.Append($"operator * : {(road1 * road2).Length}\n");
            result.Append($"operator / : {(road1 / road2).Length}\n");
            result.Append($"operator == : {(road1 == road2)}\n");
            result.Append($"operator != : {(road1 != road2)}\n");
            result.Append($"explicit: {(((Road)distance).Length)}\n");
            result.Append($"implicit: {((distance = road3).Value)}");

            return result.ToString();
        }
    }
}


