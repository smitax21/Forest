using System;
using Forest.Data.DAO;
using Forest.Data.IDAO;
using Forest.Data.Models.Domain;
using Forest.Services.IService;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var getMusicObject = musicDAO.GetMusics(id);
            return getMusicObject;
        }
        public Music GetMusic(int id)
        {
            return musicDAO.GetMusic(id);
        }
    }
}
