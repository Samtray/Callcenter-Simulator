
    public class StatusSessionLog
    {
        private int _id;
        private string _description;
        private bool _available;


        public int Id { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }
        public bool Available { get => _available; set => _available = value; }

        public StatusSessionLog(int id, string description, bool available)
        {
            Id = id;
            Description = description;
            Available = available;
        }

        public StatusSessionLog()
        {
            Id = 0;
            Description = "";
            Available = false;
        }
}
