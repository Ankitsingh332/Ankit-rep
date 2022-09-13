using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques_B
{
    [Disc(SongName = "Fitoor", Language = "Hindi", Lyrics = "Fitoor tera......")]
    internal class Song

    {
        [Disc(SongName = "Rajhna", Language = "Hindi", Lyrics = "Rajhna woo Rajhna......")]
        public int SongId { get; set; }

        [Disc(SongName = "Sayad", Language = "HINDI", Lyrics = "Sayad phir kavi.......")]
        public int ReleaseYear { get; set; }

    }
}

