using System;
using Forest.Data.Models.Domain;
using Forest.Data.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Data.IDAO
{
    public interface IArtistDAO
    {
        IList<Artist> GetArtists(int id, ForestContext context);
        void AddMusicToCollection(Music music, Artist artist, ForestContext context);
    }
}
