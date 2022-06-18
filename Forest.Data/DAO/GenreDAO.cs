using System;
using Forest.Data.IDAO;
using Forest.Data.Models.Domain;
using Forest.Data.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Forest.Data.DAO
{
    public class GenreDAO : IGenreDAO
    {
        public IList<Genre> GetGenres(ForestContext context)
        {
            return context.Genres.ToList();
        }

        //For GetGenre
        public Genre GetGenre(int id, ForestContext context)
        {
            IList<Genre> genreList = context.Genres.Include(g => g.Musics).ToList();
            var genre = context.Genres.Find(id);
            
            return genre;
        }

        public void AddMusicToCollection(Music music, Genre genre, ForestContext context)
        {
            // context.Musics.Add(music);
            context.Genres.Find(genre).Musics.Add(music);
        }
    }
}
