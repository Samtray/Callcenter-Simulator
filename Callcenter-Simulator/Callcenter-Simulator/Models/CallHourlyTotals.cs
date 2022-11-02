    public class CallHourlyTotals
    {
        private int _id;
        private DateOnly _date;
        private int _hour;
        private int _callsReceived;
        private int _callsAnswered;
        private int _callsEnded;
        private TimeSpan _handleTime;
        private TimeSpan _waitTime;

        public int Id { get => _id; set => _id = value; }
        public DateOnly Date { get => _date; set => _date = value; }
        public int Hour { get => _hour; set => _hour = value; }
        public int CallsReceived { get => _callsReceived; set => _callsReceived = value; }
        public int CallsAnswered { get => _callsAnswered; set => _callsAnswered = value; }
        public int CallsEnded { get => _callsEnded; set => _callsEnded = value; }
        public TimeSpan HandleTime { get => _handleTime; set => _handleTime = value; }
        public TimeSpan WaitTime { get => _waitTime; set => _waitTime = value; }

        public CallHourlyTotals(int id, DateOnly date, int hour, int callsReceived, int callsAnswered, int callsEnded, TimeSpan handleTime, TimeSpan waitTime)
        {
            Id = id;
            Date = date;
            Hour = hour;
            CallsReceived = callsReceived;
            CallsAnswered = callsAnswered;
            CallsEnded = callsEnded;
            HandleTime = handleTime;
            WaitTime = waitTime;
        }

        public CallHourlyTotals()
        {
            Id = 0;
            Date = new DateOnly();
            Hour = 0;
            CallsReceived = 0;
            CallsAnswered = 0;
            CallsEnded = 0;
            HandleTime = new TimeSpan();
            WaitTime = new TimeSpan();
        }
}
