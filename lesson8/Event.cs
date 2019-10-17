namespace CSharpTraining.lesson8
{
    public delegate void OutputChangeEventHandler(string input);

    internal class Teaser
    {
        private string _input;
        private event OutputChangeEventHandler _outputChange;

        public Teaser()
        {
            FromEvent = "Initial data _fromEvent";
            _outputChange += _onInput;
        }

        public string Input
        {
            get
            {
                return _input;
            }
            set
            {
                _input = value;
                _outputChange(value);
            }
        }

        public string FromEvent
        {
            get;
            set;
        }

        private void _onInput(string input)
        {
            FromEvent = input;
        }
    }
    public class Event : ILesson
    {
        public const string _key = "Event";
        private static Event _instance;
        private Event() { }

        public string Key
        {
            get { return _key; }
        }

        public static Event Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Event();
                }
                return _instance;
            }
        }

        public string GetResult()
        {
            Teaser teaser = new Teaser();
            string beforeEvent = teaser.FromEvent;
            teaser.Input = "I AM INPUT";
            string afterEvent = teaser.FromEvent;
            return $"Before event: _fromEvent = {beforeEvent}\nAfter Event: _fromEvent = {afterEvent}";
        }
    }
}
