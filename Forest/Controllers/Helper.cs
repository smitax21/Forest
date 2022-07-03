using Forest.Data.Models.Domain;
using Forest.Services.IService;
using Forest.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forest.Controllers
{
    public class Helper : Controller
    {
        IGenreService genreService;
        IArtistService artistService;

        //private List<SelectListItem> GetGenreDropDown();
        public Helper()
        {
            genreService = new GenreService();
            artistService = new ArtistService();
        }

        List<SelectListItem> GetGenreDropDownmethod()
        {
            List<SelectListItem> genreList = new List<SelectListItem>();
            IList<Genre> genres = genreService.GetGenres();
            foreach(var item in genres)
            {
                genreList.Add(new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.ID.ToString(),
                    Selected = (item.Name == (genres[0].Name) ? true : false)
                }
                );
            }
            return genreList;
        }

        List<SelectListItem> GetArtistDropDownmethod(int id)
        {
            List<SelectListItem> artistList = new List<SelectListItem>();
            IList<Artist> artists = artistService.GetArtists(id);
            foreach (var item in artists)
            {
                artistList.Add(new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.ID.ToString(),
                    Selected = (item.Name == (artists[0].Name) ? true : false)
                }
                );
            }
            return artistList;
        }

        public List<SelectListItem> GetGenreDropDown()
        {
            return GetGenreDropDownmethod();
        }

        public List<SelectListItem> GetArtistDropDown(int id)
        {
            return GetArtistDropDownmethod(id);
        }
        public IEnumerable<SelectListItem> GetSelectList<T>(IList<T> list,
            Func<T, object> funcToGetValue,
            Func<T, object> funcToGetText)
        {
            return list.Select(x => new SelectListItem
            {
                Value = funcToGetValue(x).ToString(),
                Text = funcToGetText(x).ToString()
            });
        }
    }
    
}