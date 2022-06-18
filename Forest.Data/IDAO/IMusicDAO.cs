using System;
using Forest.Data.Models.Domain;
using Forest.Data.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Data.IDAO
{
    public interface IMusicDAO
    {
        //For Music
        IList<Music> GetMusics(int id, ForestContext context);
        Music GetMusic(int id, ForestContext context);

        void AddMusic(Music music, ForestContext context);
    }
}
