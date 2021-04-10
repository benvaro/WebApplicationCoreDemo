using System.Collections.Generic;

namespace FilmsApi.Data
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Film> Films { get; set; }

        public Genre()
        {
            Films = new List<Film>();
        }
    }
}
