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
        private IArtistDAO artistDAO;
        private IUserDAO userDAO;

        public MusicService()
        {
            musicDAO = new MusicDAO();
            genreDAO = new GenreDAO();
            artistDAO = new ArtistDAO();
            userDAO = new UserDAO();

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
                musicDAO.AddMusic(newMusic, context);//Add Music
                Genre genre = genreDAO.GetGenre(musicGenreArtist.Genre, context); //Create Genre object
                genreDAO.AddMusicToCollection(newMusic, genre, context); //Add music to collection of Genre
                Artist artist = (Artist)artistDAO.GetArtists(musicGenreArtist.Artist, context); //Create Artist object
                artistDAO.AddMusicToCollection(newMusic, artist, context);//Add Music to collection of Artist
                userDAO.AddMusicToCollection(newMusic, userId, context);

                context.SaveChanges();
            }//Context object is disposed
            #endregion
        }
    }
}
