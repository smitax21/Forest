using System;
using Forest.Data.Models.Domain;
using Forest.Data.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Data.IDAO
{
    public interface IUserDAO
    {
        void AddMusicToCollection(Music music, string userId, ForestContext context);
        void AddToCollection(string userId, Music newMusic, ForestContext context);
    }
}
