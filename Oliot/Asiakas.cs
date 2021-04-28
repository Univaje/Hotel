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

        public int AsiakasID { get => asiakas_ID; set => asiakas_ID = value; }
        public string Etunimi { get => etunimi; set => etunimi = value; }
        public string Sukunimi { get => sukunimi; set => sukunimi = value; }
        public string Lähiosoite { get => lahiosoite; set => lahiosoite = value; }
        public string Sähköpostiosoite { get => email; set => email = value; }
        public string Puhelinnumero { get => puhelinNro; set => puhelinNro = value; }
        public string Postinumero { get => postinumero; set => postinumero = value; }

        public Asiakas()
        {
        }

        public Asiakas(int asiakasID, string postinumero, string etunimi, string sukunimi, string osoite, string email, string puhelinNro )
        {
            AsiakasID = asiakasID;
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Lähiosoite = osoite;
            Sähköpostiosoite = email;
            Puhelinnumero = puhelinNro;
            Postinumero = postinumero;
        }
    }

}
