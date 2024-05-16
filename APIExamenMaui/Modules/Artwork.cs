using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIExamenMaui.Modules
{
    public class Artwork
    {
        public int IdArt { get; set; }
        public string Name { get; set; }

        public string PublicationYear { get; set; }

        public string Technique { get; set; }
        public string Description { get; set; }

        public int? Artistid { get; set; }
    }
}
