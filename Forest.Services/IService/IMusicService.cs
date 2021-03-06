using System;
using Forest.Data.Models.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Services.Models;

namespace Forest.Services.IService
{
    public interface IMusicService
    {
        //For Music
        IList<Music> GetMusics(int id);
        Music GetMusic(int id);
        void AddMusic(MusicGenreArtist musicGenreArtist, string userId);
    }
}
