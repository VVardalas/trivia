namespace Trivia
{
    internal class Player
    {
        public string Name { get; }

        public int Place { get; private set; }

        public Player(string name)
        {
            Name = name;
            Place = 0;
        }

        public void Move(int roll)
        {
            Place += roll;
            if (Place > 11) Place -= 12;
        }
    }
}