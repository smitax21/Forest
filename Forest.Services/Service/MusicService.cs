using System;
using Forest.Data.DAO;
using Forest.Data.IDAO;
using Forest.Data.Models.Domain;
using Forest.Services.IService;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data.Repository;

namespace Forest.Services.Service
{
    public class MusicService : IMusicService
    {
        private IMusicDAO musicDAO;
        public MusicService()
        {
            musicDAO = new MusicDAO();
        }

        //For Music
        public IList<Music> GetMusics(int id)
        {
            using( var context = new ForestContext())
            {
                var getMusicObject = musicDAO.GetMusics(id, context);
                return getMusicObject;
            }
        }
        public Music GetMusic(int id)
        {
            using (var context = new ForestContext())
            {
                return musicDAO.GetMusic(id, context);
            }
        }
    }
}
