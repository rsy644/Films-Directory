using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcFilm.Models
{
    public class FilmGenreViewModel
        // Films Genre view: Contains:
            // - A list of films
            // - A select list covering a list of genres.
            // - A searchstring, which contains text that the users enter into the the search text box.
    {
        public List<Film> Films { get; set; }
        public SelectList Genres { get; set; }
        public string FilmGenre { get; set; }
        public string SearchString { get; set; }
    }
}
