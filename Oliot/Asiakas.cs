using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Asiakas
    {
        private int asiakasID;
        private string etunimi;
        private string sukunimi;
        private string osoite;
        private string email;
        private string puhelinNro;
        private string postinumero;

        public int AsiakasID { get => asiakasID; set => asiakasID = value; }
        public string Etunimi { get => etunimi; set => etunimi = value; }
        public string Sukunimi { get => sukunimi; set => sukunimi = value; }
        public string Osoite { get => osoite; set => osoite = value; }
        public string Email { get => email; set => email = value; }
        public string PuhelinNro { get => puhelinNro; set => puhelinNro = value; }
        public string Postinumero { get => postinumero; set => postinumero = value; }

        public Asiakas()
        {
        }

        public Asiakas(int asiakasID, string postinumero, string etunimi, string sukunimi, string osoite, string email, string puhelinNro )
        {
            AsiakasID = asiakasID;
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Osoite = osoite;
            Email = email;
            PuhelinNro = puhelinNro;
            Postinumero = postinumero;
        }
    }

}
