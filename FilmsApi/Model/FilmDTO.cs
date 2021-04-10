namespace FilmsApi.Model
{
    public class FilmDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }

        public int GenreId { get; set; }
    }
}
