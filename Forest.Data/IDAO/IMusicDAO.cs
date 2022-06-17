using System;
using Forest.Data.Models.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Data.IDAO
{
    public interface IMusicDAO
    {
        //For Music
        IList<Music> GetMusics(int id);
        Music GetMusic(int id);
    }
}
