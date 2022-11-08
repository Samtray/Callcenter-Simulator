using System.Data.SqlClient;

public class Call
{
        private static string select = "select * from calls order by datetimeReceived desc";

        private int _id;
        private DateTime _datetimeReceived;
        private DateTime _datetimeAnswered;
        private DateTime _datetimeEnded;
        private string _phoneNumber;
        private int _idSession;
        private int _idStatus;
        private int _idStatusEnd;

       
        public int Id { get => _id; set => _id = value; }
        public DateTime DatetimeReceived { get => _datetimeReceived; set => _datetimeReceived = value; }
        public DateTime DatetimeAnswered { get => _datetimeAnswered; set => _datetimeAnswered = value; }
        public DateTime DatetimeEnded { get => _datetimeEnded; set => _datetimeEnded = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public int IdSession { get => _idSession; set => _idSession = value; }
        public int IdStatus { get => _idStatus; set => _idStatus = value; }
        public int IdStatusEnd { get => _idStatusEnd; set => _idStatusEnd = value; }

        public Call(int id, DateTime dateTimeReceived, DateTime datetimeAnswered, DateTime datetimeEnded, string phoneNumber, int idSession, int idStatus, int idStatusEnd)
        {
            Id = id;
            DatetimeReceived = dateTimeReceived;
            DatetimeAnswered = datetimeAnswered;
            DatetimeEnded = datetimeEnded;
            PhoneNumber = phoneNumber;
            IdSession = idSession;
            IdStatus = idStatus;
            IdStatusEnd = idStatusEnd;
        }

        public Call()
        {
            Id = 0;
            DatetimeReceived = new DateTime();
            DatetimeAnswered = new DateTime();
            DatetimeEnded = new DateTime();
            PhoneNumber = "";
            IdSession = 0;
            IdStatus = 0;
            IdStatusEnd = 0;
        }

        public static List<Call> GetAll()
        {
            SqlCommand command = new SqlCommand(select);
            return CallMapper.ToList(SqlServerConnection.ExecuteQuery(command));
        }
}
