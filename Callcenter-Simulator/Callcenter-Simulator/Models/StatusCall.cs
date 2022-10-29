    public class StatusCall
    {
        private int _id;
        private string _description;
        private bool _availableToAnswer;

        public int Id { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }
        public bool AvailableToAnswer { get => _availableToAnswer; set => _availableToAnswer = value; }

        public StatusCall(int id, string description, bool availableToAnswer)
        {
            Id = id;
            Description = description;
            AvailableToAnswer = availableToAnswer;
        }

        public StatusCall()
        {
            Id = 0;
            Description = "";
            AvailableToAnswer = false;
        }
}
