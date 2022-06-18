using System;
using Forest.Data.Models.Domain;
using Forest.Data.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Data.IDAO
{
    public interface IGenreDAO
    {
        //For Genre
        IList<Genre> GetGenres(ForestContext context);
        Genre GetGenre(int id, ForestContext context);

        void AddMusicToCollection(Music music, Genre genre, ForestContext context);
        void AddToCollection(Genre genre, Music newMusic, ForestContext context);
    }
}
