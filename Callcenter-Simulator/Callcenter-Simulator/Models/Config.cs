    public class Config
    {
        private double _standardHandleTime;
        private double _standardWaitTime;
        private int _idDefaultSessionLogStatus;
        private int _idDefaultCallReceiveStatus;
        private int _idDefaultCallAnswerStatus;
        private int _idDefaultCallEndStatus;

        public double StandardHandleTime { get => _standardHandleTime; set => _standardHandleTime = value; }
        public double StandardWaitTime { get => _standardWaitTime; set => _standardWaitTime = value; }
        public int IdDefaultSessionLogStatus { get => _idDefaultSessionLogStatus; set => _idDefaultSessionLogStatus = value; }
        public int IdDefaultCallReceiveStatus { get => _idDefaultCallReceiveStatus; set => _idDefaultCallReceiveStatus = value; }
        public int IdDefaultCallAnswerStatus { get => _idDefaultCallAnswerStatus; set => _idDefaultCallAnswerStatus = value; }
        public int IdDefaultCallEndStatus { get => _idDefaultCallEndStatus; set => _idDefaultCallEndStatus = value; }

        public Config(double standardHandleTime, double standardWaitTime, int idDefaultSessionLogStatus, int idDefaultCallReceiveStatus, int idDefaultCallAnswerStatus, int idDefaultCallEndStatus)
        {
            StandardHandleTime = standardHandleTime;
            StandardWaitTime = standardWaitTime;
            IdDefaultSessionLogStatus = idDefaultSessionLogStatus;
            IdDefaultCallReceiveStatus = idDefaultCallReceiveStatus;
            IdDefaultCallAnswerStatus = idDefaultCallAnswerStatus;
            IdDefaultCallEndStatus = idDefaultCallEndStatus;
        }

        public Config()
        {
            StandardHandleTime = 0;
            StandardWaitTime = 0;
            IdDefaultSessionLogStatus = 0;
            IdDefaultCallReceiveStatus = 0;
            IdDefaultCallAnswerStatus = 0;
            IdDefaultCallEndStatus = 0;
        }
}
