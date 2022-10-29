
    public class StatusCallEnd
    {
        private int _id;
        private string _description;

        public int Id { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }
        public StatusCallEnd(int id, string description)
        {
            Id = id;
            Description = description;
        }
        public StatusCallEnd()
        {
            Id = 0;
            Description = "";
        }
}
