    public class Agent
    {
        private int _id;
        private string _name;
        private string _photo;
        private int _pin;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Photo { get => _photo; set => _photo = value; }
        public int Pin { get => _pin; set => _pin = value; }

        public Agent(int id, string name, string photo, int pin)
        {
            Id = id;
            Name = name;
            Photo = photo;
            Pin = pin;
        }

        public Agent()
        {
            Id = 0;
            Name = "";
            Photo = "";
            Pin = 0;
        }
}
