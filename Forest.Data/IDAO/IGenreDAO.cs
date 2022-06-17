using System;
using Forest.Data.Models.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Data.IDAO
{
    public interface IGenreDAO
    {
        //For Genre
        IList<Genre> GetGenres();
        Genre GetGenre(int id);

       
       
    }
}
