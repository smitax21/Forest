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
using Forest.Services.Models;

namespace Forest.Services.Service
{
    public class MusicService : IMusicService
    {
        private IMusicDAO musicDAO;
        private IGenreDAO genreDAO;
        private IUserDAO userDAO;
        private IArtistDAO artistDAO;
        public MusicService()
        {
            musicDAO = new MusicDAO();
            genreDAO = new GenreDAO();
            //userDAO = new UserDAO();
            //artistDAO = new ArtistDAO();
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

        public void AddMusic(MusicGenreArtist musicGenreArtist, string userId)
        {
            #region - //Create the new Music Object
            Music newMusic = new Music()
            {
                //Dress up Music object using values of attributes
                Title = musicGenreArtist.Title,
                num_track = musicGenreArtist.num_track,
                duration = musicGenreArtist.duration,
                DateReleased = musicGenreArtist.DateReleased,
                Price = musicGenreArtist.Price,
                Image = musicGenreArtist.Image
            };
            #endregion

            #region - Do work with DAOs to add object and add to collections
            using (var context = new ForestContext())
            {
                //context object is created
                musicDAO.AddMusic(newMusic, context); //Add music
                Genre genre = genreDAO.GetGenre(musicGenreArtist.Genre, context); //Create Genre object
                genreDAO.AddToCollection(genre, newMusic, context);//Add music to collection of Genre
                Artist artist = (Artist)artistDAO.GetArtists(musicGenreArtist.Artist, context);
                artistDAO.AddToCollection(artist, newMusic, context);//Add music to collection of Artist
                userDAO.AddToCollection(userId, newMusic, context);//Add music to collection of User

                context.SaveChanges();
            }//Context object is disposed
            #endregion
        }
    }
}
