namespace CarSej.Service
{
    public class ConstDeyerler
    {
        public int Id { get; set; }
        public static int Counter { get; private set; }
        public ConstDeyerler()
        {
            Counter++;
            Id = Counter;
        }
    }
}
