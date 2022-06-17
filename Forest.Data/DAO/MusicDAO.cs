﻿using System;
using Forest.Data.IDAO;
using Forest.Data.Models.Domain;
using Forest.Data.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Forest.Data.DAO
{
    public class MusicDAO : IMusicDAO
    {
        private ForestContext context;

        public MusicDAO()
        {
            context = new ForestContext();
        }

        //For GetMusics
        public IList<Music> GetMusics(int id)
        {
            Genre genre = context.Genres.Find(id);
            IList<Music> music = context.Genres.Find(id).Musics.ToList();
            return music;

        }
        public Music GetMusic(int id)
        {

            var music = context.Musics.Find(id);
            return music;

        }
    }
}
