    public class Call
    {
        private int _id;
        private DateTime _dateTimeReceived;
        private DateTime _datetimeAnswered;
        private string _phoneNumber;
        private int _idSession;
        private int _idStatus;
        private int _idStatusEnd;

       
        public int Id { get => _id; set => _id = value; }
        public DateTime DateTimeReceived { get => _dateTimeReceived; set => _dateTimeReceived = value; }
        public DateTime DatetimeAnswered { get => _datetimeAnswered; set => _datetimeAnswered = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public int IdSession { get => _idSession; set => _idSession = value; }
        public int IdStatus { get => _idStatus; set => _idStatus = value; }
        public int IdStatusEnd { get => _idStatusEnd; set => _idStatusEnd = value; }

        public Call(int id, DateTime dateTimeReceived, DateTime datetimeAnswered, string phoneNumber, int idSession, int idStatus, int idStatusEnd)
        {
            Id = id;
            DateTimeReceived = dateTimeReceived;
            DatetimeAnswered = datetimeAnswered;
            PhoneNumber = phoneNumber;
            IdSession = idSession;
            IdStatus = idStatus;
            IdStatusEnd = idStatusEnd;
        }

        public Call()
        {
            Id = 0;
            DateTimeReceived = new DateTime();
            DatetimeAnswered = new DateTime();
            PhoneNumber = "";
            IdSession = 0;
            IdStatus = 0;
            IdStatusEnd = 0;
        }
}
