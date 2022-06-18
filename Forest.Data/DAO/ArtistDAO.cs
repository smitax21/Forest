using System;
using Forest.Data.Models.Domain;
using Forest.Data.Repository;
using Forest.Data.IDAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Data.DAO
{
    public class ArtistDAO
    {
        public IList<Artist> GetArtists(int id, ForestContext context)
        {
            return (IList<Artist>) context.Genres.ToList();
        }
        public void AddMusicToCollection(Music music, Artist artist, ForestContext context)
        {
            context.Artists.Find(artist).Musics.Add(music);
        }
    }
}
