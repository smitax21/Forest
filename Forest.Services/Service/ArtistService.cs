using System;
using Forest.Data.Models.Domain;
using Forest.Data.Repository;
using Forest.Services.IService;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data.DAO;

namespace Forest.Services.Service
{
    public class ArtistService : IArtistService
    {
        private ArtistDAO artistDAO;
        public ArtistService()
        {
            artistDAO = new ArtistDAO();
        }

        public IList<Artist> GetArtists(int id)
        {
            using(var context = new ForestContext())
            {
                var getMusicObject = artistDAO.GetArtists(id, context);
                return getMusicObject;
            }
        }
    }
}
