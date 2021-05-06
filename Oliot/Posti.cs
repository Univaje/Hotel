using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Oliot
{
    internal class Posti
    {
        private string postinro;
        private string toimipaikka;

        public string Postinro { get => postinro; set => postinro = value; }
        public string Toimipaikka { get => toimipaikka; set => toimipaikka = value; }

        public Posti(string postinro, string toimipaikka)
        {
            Postinro = postinro;
            Toimipaikka = toimipaikka;
        }

        public Posti()
        {
        }

        public List<Posti> HaetPostinrot()
        {
            List<Posti> Postinumerot = new List<Posti>();
            Postinumerot = LFDB.getPostinro();
            return Postinumerot;
        }
    }
}
