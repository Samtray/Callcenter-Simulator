
    public class Session
    {
        private int _id;
        private DateTime _dateTimeLogin;
        private DateTime _dateTimeLogout;
        private int _idAgent;   
        private int _idStation;
        private int _idCurrentCall;
        private bool _active;

    
        public int Id { get => _id; set => _id = value; }
        public DateTime DateTimeLogin { get => _dateTimeLogin; set => _dateTimeLogin = value; }
        public DateTime DateTimeLogout { get => _dateTimeLogout; set => _dateTimeLogout = value; }
        public int IdAgent { get => _idAgent; set => _idAgent = value; }
        public int IdStation { get => _idStation; set => _idStation = value; }
        public int IdCurrentCall { get => _idCurrentCall; set => _idCurrentCall = value; }
        public bool Active { get => _active; set => _active = value; }

        public Session(int id, DateTime dateTimeLogin, DateTime dateTimeLogout, int idAgent, int idStation, int idCurrentCall, bool active)
        {
            Id = id;
            DateTimeLogin = dateTimeLogin;
            DateTimeLogout = dateTimeLogout;
            IdAgent = idAgent;
            IdStation = idStation;
            IdCurrentCall = idCurrentCall;
            Active = active;
        }

        public Session()
        {
            Id = 0;
            DateTimeLogin = new DateTime();
            DateTimeLogout = new DateTime();
            IdAgent = 0;
            IdStation = 0;
            IdCurrentCall = 0;
            Active = false;
        }

}
