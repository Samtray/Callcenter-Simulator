
    public class CallDailyTotals
    {
        private int _id;
        private DateOnly _date;
        private int _callsReceived;
        private TimeSpan _averageHandleTime;
        private TimeSpan _averageWaitTime;


        public int Id { get => _id; set => _id = value; }
        public DateOnly Date { get => _date; set => _date = value; }
        public int CallsReceived { get => _callsReceived; set => _callsReceived = value; }
        public TimeSpan AverageHandleTime { get => _averageHandleTime; set => _averageHandleTime = value; }
        public TimeSpan AverageWaitTime { get => _averageWaitTime; set => _averageWaitTime = value; }

        public CallDailyTotals(int id, DateOnly date, int callsReceived, TimeSpan averageHandleTime, TimeSpan averageWaitTime)
        {
            Id = id;
            Date = date;
            CallsReceived = callsReceived;
            AverageHandleTime = averageHandleTime;
            AverageWaitTime = averageWaitTime;
        }

        public CallDailyTotals()
        {
            Id = 0;
            Date = new DateOnly();
            CallsReceived = 0;
            AverageHandleTime = new TimeSpan();
            AverageWaitTime = new TimeSpan();
        }
}

