namespace FilmsApi.Data
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }

        public Genre Genre { get; set; }
    }
}
