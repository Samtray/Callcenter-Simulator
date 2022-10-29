public class SessionLog
    {
        private int _id;
        private int _idSession;
        private DateTime _dateTimeStart;
        private DateTime _dateTimeEnd;
        private int _idStatus;

        public int Id { get => _id; set => _id = value; }
        public int IdSession { get => _idSession; set => _idSession = value; }
        public DateTime DateTimeStart { get => _dateTimeStart; set => _dateTimeStart = value; }
        public DateTime DateTimeEnd { get => _dateTimeEnd; set => _dateTimeEnd = value; }
        public int IdStatus { get => _idStatus; set => _idStatus = value; }

        public SessionLog(int id, int idSession, DateTime dateTimeStart, DateTime dateTimeEnd, int idStatus)
        {
            Id = id;
            IdSession = idSession;
            DateTimeStart = dateTimeStart;
            DateTimeEnd = dateTimeEnd;
            IdStatus = idStatus;
        }

       public SessionLog()
        {
            Id = 0;
            IdSession = 0;
            DateTimeStart = new DateTime();
            DateTimeEnd = new DateTime();
            IdStatus = 0;
        }
}
