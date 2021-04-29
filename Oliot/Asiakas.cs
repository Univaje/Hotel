using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hotel
{
    class Asiakas
    {
        private int asiakas_ID;
        private string etunimi;
        private string sukunimi;
        private string lahiosoite;
        private string email;
        private string puhelinNro;
        private string postinumero;

        public int Asiakas_ID { get => asiakas_ID; set => asiakas_ID = value; }
        public string Etunimi { get => etunimi; set => etunimi = value; }
        public string Sukunimi { get => sukunimi; set => sukunimi = value; }
        public string Lahiosoite { get => lahiosoite; set => lahiosoite = value; }
        public string Email { get => email; set => email = value; }
        public string PuhelinNro { get => puhelinNro; set => puhelinNro = value; }
        public string Postinro { get => postinumero; set => postinumero = value; }

        public Asiakas()
        {
        }

        public Asiakas(int asiakasID, string postinumero, string etunimi, string sukunimi, string osoite, string email, string puhelinNro )
        {
            Asiakas_ID = asiakasID;
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Lahiosoite = osoite;
            Email = email;
            PuhelinNro = puhelinNro;
            Postinro = postinumero;
        }
    }

}
