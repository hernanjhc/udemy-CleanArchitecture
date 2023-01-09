using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain
{
    public class Video
    {
        public int Id { get; set; }
        public string? Nonmbre { get; set; }

        //Definicion clave foranea
        //se crea columna que representa a streamer
        public int StreamerId { get; set; }
        public virtual Streamer? Streamer { get; set; }

    }
}
