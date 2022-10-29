
public class Station
    {
        private int _id;
        private int _rowNumber;
        private int _deskNumber;
        private string _ipAddress;
        private bool _active;

        public int Id { get => _id; set => _id = value; }
        public int RowNumber { get => _rowNumber; set => _rowNumber = value; }
        public int DeskNumber { get => _deskNumber; set => _deskNumber = value; }
        public string IpAddress { get => _ipAddress; set => _ipAddress = value; }
        public bool Active { get => _active; set => _active = value; }

        public Station(int id, int rowNumber, int deskNumber, string ipAddress, bool active)
        {
            Id = id;
            RowNumber = rowNumber;
            DeskNumber = deskNumber;
            IpAddress = ipAddress;
            Active = active;
        }

        public Station()
        {
            Id = 0;
            RowNumber = 0;
            DeskNumber = 0;
            IpAddress = "";
            Active = false;
        }

}

