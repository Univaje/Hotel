using Hotel.Oliot;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Hotel
{

    class LFDB : LFDBBase
    {
        public static MySqlConnection connect = null;
        public static List<mokki> mokit = new List<mokki>();
        public static List<Asiakas> asiakkaat = new List<Asiakas>();
        public static List<Palvelu> palvelut = new List<Palvelu>();
        public static List<Lasku> Laskut = new List<Lasku>();
        public static List<LaskuRaportti> LaskuRaportit = new List<LaskuRaportti>();
        public static List<Toimialue> toimintaalueet = new List<Toimialue>();
        public static List<Varaus> Varaukset = new List<Varaus>();
        public static List<Varaustiedot> VarausienTiedot = new List<Varaustiedot>();
        public static List<PalvelutVaraukseen> PalveluidenlisVar = new List<PalvelutVaraukseen>();
        public static List<MokkiRaportti> MokkiRaportit = new List<MokkiRaportti>();
        public static List<Posti> Postinumerot = new List<Posti>();
        public static List<PalveluRaportti> PalveluRaportit = new List<PalveluRaportti>();

        static string myConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=Ruutti;database=vn;port=3307";

        /* Mokkien Tietokanta haut*/
        public static List<mokki> getMokit() // toimiva
        {
            mokit.Clear();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  mokki ";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    mokki haemokit = new mokki(int.Parse(Reader[0].ToString()), int.Parse(Reader[1].ToString()), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString(), Reader[5].ToString(), int.Parse(Reader[6].ToString()), Reader[7].ToString(), double.Parse(Reader[8].ToString()));
                    mokit.Add(haemokit);
                }
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            return mokit;
        }
        public static void SetMokki(mokki m)  
        {
            
            try
            {
                NumberFormatInfo provider = new NumberFormatInfo();                    
                provider.NumberDecimalSeparator = ".";                                
                provider.NumberGroupSeparator = ",";                                  
                double temp = Convert.ToDouble(m.Hinta, provider);                

                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "INSERT INTO mokki(mokki_id,toimintaalue_id,postinro,mokkinimi,katuosoite,kuvaus,henkilomaara,varustelu,hinta) VALUES " +
                    "(@mokki_id , @toimi,  @postinro,@mokkinimi,@katuosoite,@kuvaus,@henkilomaara,@varustelu,@hinta )";
                MySqlCommand Parametreille = new MySqlCommand(sql, connect);
                Parametreille.Parameters.Add("@mokki_id", MySqlDbType.Int32).Value = default;
                Parametreille.Parameters.Add("@toimi", MySqlDbType.Int32).Value = m.ToimintaalueID;
                Parametreille.Parameters.Add("@postinro", MySqlDbType.VarChar).Value = m.Postinumero;
                Parametreille.Parameters.Add("@mokkinimi", MySqlDbType.VarChar).Value = m.Mokkinimi;
                Parametreille.Parameters.Add("@katuosoite", MySqlDbType.VarChar).Value = m.Katuosoite;
                Parametreille.Parameters.Add("@kuvaus", MySqlDbType.VarChar).Value = m.Kuvaus;
                Parametreille.Parameters.Add("@henkilomaara", MySqlDbType.Int32).Value = m.Henkilomaara;
                Parametreille.Parameters.Add("@varustelu", MySqlDbType.VarChar).Value = m.Varustelu;
                Parametreille.Parameters.Add("@hinta", MySqlDbType.Double).Value = m.Hinta;

                Parametreille.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }

        }
        public static List<mokki> getMokitToiauleittain(int i)  // toimiva
        {
            mokit.Clear();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  mokki WHERE toimintaalue_id = " + i;
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    mokki haeMokit = new mokki(int.Parse(Reader[0].ToString()), int.Parse(Reader[1].ToString()), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString(), Reader[5].ToString(), int.Parse(Reader[6].ToString()), Reader[7].ToString(), double.Parse(Reader[8].ToString()));
                    mokit.Add(haeMokit);
                }
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            return mokit;
        }
        public static List<mokki> RemoveMokki(int i)  // toimiiko?
        {
            mokit = new List<mokki>();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "DELETE FROM  mokki WHERE mokki_id = " + i;
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            return mokit;
        }
        public static void UpdateMokki(mokki m)  // Toimiva
        {

            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "UPDATE mokki SET mokki_id = @mokki_id, toimintaalue_id = @toimi , postinro = @postinro , mokkinimi = @mokkinimi , katuosoite = @katuosoite , kuvaus = @kuvaus , henkilomaara = @henkilomaara , varustelu = @varustelu , hinta = @hinta WHERE mokki_id = @mokki_id";
                MySqlCommand Parametreille = new MySqlCommand(sql, connect);
                Parametreille.Parameters.Add("@mokki_id", MySqlDbType.Int32).Value = m.MokkiID;
                Parametreille.Parameters.Add("@toimi", MySqlDbType.Int32).Value = m.ToimintaalueID;
                Parametreille.Parameters.Add("@postinro", MySqlDbType.VarChar).Value = m.Postinumero;
                Parametreille.Parameters.Add("@mokkinimi", MySqlDbType.VarChar).Value = m.Mokkinimi;
                Parametreille.Parameters.Add("@katuosoite", MySqlDbType.VarChar).Value = m.Katuosoite;
                Parametreille.Parameters.Add("@kuvaus", MySqlDbType.VarChar).Value = m.Kuvaus;
                Parametreille.Parameters.Add("@henkilomaara", MySqlDbType.Int32).Value = m.Henkilomaara;
                Parametreille.Parameters.Add("@varustelu", MySqlDbType.VarChar).Value = m.Varustelu;
                Parametreille.Parameters.Add("@hinta", MySqlDbType.Decimal).Value = m.Hinta;

                Parametreille.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }


        }

        /* Postinumeroiden Tietokanta haut*/
        public static List<Posti> getPostinro() // toimiiva
        {
            Postinumerot.Clear();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  posti ";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Posti haeNumerot = new Posti(Reader[0].ToString(), Reader[1].ToString());
                    Postinumerot.Add(haeNumerot);
                }
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }

            return Postinumerot;
        }
        public static void setPostinro(Posti p) // toimiiko?
        {

            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "INSERT INTO Posti(postinro,toimipaikka) VALUES ('" + p.Postinro + "','" + p.Toimipaikka + "')";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
        }

        /* Mokkiraporttien Tietokanta haut*/
        public static List<MokkiRaportti> getMokkiRaportti(int i, DateTime a, DateTime l) // Ei toimi
        {

            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  raportti where mokki_id = @mokki AND varattu_alkupvm > @alku AND varattu_loppupvm < @loppu";
                MySqlCommand Parametreille = new MySqlCommand(sql, connect);
                Parametreille.Parameters.Add("@mokki", MySqlDbType.Int32).Value = i;
                Parametreille.Parameters.Add("@alku", MySqlDbType.DateTime).Value = a;
                Parametreille.Parameters.Add("@loppu", MySqlDbType.DateTime).Value = l;
                MySqlDataReader Reader = Parametreille.ExecuteReader();
                while (Reader.Read())
                {
                    MokkiRaportti haeraportti = new MokkiRaportti(int.Parse(Reader[0].ToString()), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString(), int.Parse(Reader[5].ToString()), DateTime.Parse(Reader[6].ToString()), DateTime.Parse(Reader[7].ToString()), double.Parse(Reader[8].ToString()));
                    MokkiRaportit.Add(haeraportti);
                }
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            return MokkiRaportit;
        }

        /* Toimialueiden Tietokanta haut*/
        public static List<Toimialue> GetToimialue() 
        {
            toimintaalueet.Clear();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  Toimintaalue ORDER BY toimintaalue_id ";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Toimialue haealueet = new Toimialue(int.Parse(Reader[0].ToString()), Reader[1].ToString());
                    toimintaalueet.Add(haealueet);
                }
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            return toimintaalueet;
        }
        public static void SetToimialue( string s) 
        {

            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "INSERT INTO toimintaalue(toimintaalue_id,nimi) VALUES ( @toimialue, @nimi);";
                MySqlCommand cmd = new MySqlCommand(sql, connect);

                cmd.Parameters.Add("@toimialue", MySqlDbType.Int64).Value = default;
                cmd.Parameters.Add("@nimi", MySqlDbType.VarChar).Value = s;
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }

        }
        public static void RemoveToimialue(int i) 
        {
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "DELETE FROM toimintaalue WHERE toimintaalue_id=" + i;
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }

        }
        public static void UpdateToimialue(int i, string s) 
        {

            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "UPDATE toimintaalue SET nimi='" + s + "' WHERE toimintaalue_id=" + i;
                MySqlCommand cmd = new MySqlCommand(sql, connect);

                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }

        }

        /* Palveluiden Tietokanta haut*/
        public static List<Palvelu> getPalvelut()  
        {
            palvelut.Clear();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  palvelu ";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Palvelu haePalvelut = new Palvelu(int.Parse(Reader[0].ToString()), int.Parse(Reader[1].ToString()), Reader[2].ToString(), int.Parse(Reader[3].ToString()), Reader[4].ToString(), double.Parse(Reader[5].ToString()), double.Parse(Reader[6].ToString()));
                    palvelut.Add(haePalvelut);
                }
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            return palvelut;
        }
        public static List<Palvelu> getPalvelutToimiAlueella(int i)  
        {
            palvelut.Clear();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  palvelu WHERE toimintaalue_id = " + i;
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Palvelu haePalvelut = new Palvelu(int.Parse(Reader[0].ToString()), int.Parse(Reader[1].ToString()), Reader[2].ToString(), int.Parse(Reader[3].ToString()), Reader[4].ToString(), double.Parse(Reader[5].ToString()), double.Parse(Reader[6].ToString()));
                    palvelut.Add(haePalvelut);
                }
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            return palvelut;
        }

        /* Asiakkaiden Tietokanta haut*/
        public static List<Asiakas> getAsiakas()  
        {
            asiakkaat.Clear();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  asiakas ";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Asiakas haeAsiakkaat = new Asiakas(int.Parse(Reader[0].ToString()), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString(), Reader[5].ToString(), Reader[6].ToString());
                    asiakkaat.Add(haeAsiakkaat);
                }
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            return asiakkaat;
        }
        public static List<Asiakas> getAsiakasBySukunimi(string hakunimi)
        {
            asiakkaat.Clear();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  asiakas WHERE sukunimi LIKE '" + hakunimi + "%' ORDER BY sukunimi";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Asiakas haeAsiakkaat = new Asiakas(int.Parse(Reader[0].ToString()), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString(), Reader[5].ToString(), Reader[6].ToString());
                    asiakkaat.Add(haeAsiakkaat);
                }
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            return asiakkaat;
        }
        public static void SetAsiakasAlt(Asiakas a)  //  Annetaan ID:ksi tietokannalle NULL, auto increment hoitaa ID määrittämisen
        {

            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "INSERT INTO asiakas(asiakas_id,etunimi,sukunimi,lahiosoite,email,puhelinnro,postinro) VALUES " +
                    "(NULL,'" + a.Etunimi + "','" + a.Sukunimi + "','" + a.Lahiosoite + "','" + a.Sahkopostiosoite + "','" + a.Puhelinnumero +
                    "','" + a.Postinumero + "')";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }

        }
        public static void RemoveAsiakas(int i)
        {
            //asiakkaat = new List<Asiakas>();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "DELETE FROM asiakas WHERE asiakas_id = " + i;
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            //return asiakkaat;
        }
        public static void UpdateAsiakas(Asiakas a) 
        {

            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "UPDATE asiakas SET asiakas_id = @asiakas_id , postinro = @postinro , etunimi = @etunimi , sukunimi = @sukunimi , lahiosoite = @lahiosoite , email = @email , puhelinnro = @puhelinnro WHERE asiakas_id = @asiakas_id";
                MySqlCommand Parametreille = new MySqlCommand(sql, connect);
                Parametreille.Parameters.Add("@asiakas_id", MySqlDbType.Int32).Value = a.AsiakasID;
                
                Parametreille.Parameters.Add("@postinro", MySqlDbType.VarChar).Value = a.Postinumero;
                Parametreille.Parameters.Add("@etunimi", MySqlDbType.VarChar).Value = a.Etunimi;
                Parametreille.Parameters.Add("@sukunimi", MySqlDbType.VarChar).Value = a.Sukunimi;
                Parametreille.Parameters.Add("@lahiosoite", MySqlDbType.VarChar).Value = a.Lahiosoite;
                
                Parametreille.Parameters.Add("@email", MySqlDbType.VarChar).Value = a.Sahkopostiosoite;
                Parametreille.Parameters.Add("@puhelinnro", MySqlDbType.VarChar).Value = a.Puhelinnumero;

                Parametreille.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }


        }

        public static int GetLastAsiakasID()
        {
            int ID = 0;
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT MAX(asiakas_id) FROM  asiakas ";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    ID = int.Parse(Reader[0].ToString());
                }
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }


            return ID;
        }


        /* Laskujen Tietokanta haut*/
        public static List<LaskuRaportti> getLaskuTuloste(int la)
        {

            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  lasku WHERE lasku_id = @lasku ";
                MySqlCommand Parametreille = new MySqlCommand(sql, connect);
                Parametreille.Parameters.Add("@lasku", MySqlDbType.Int32).Value = la;
                MySqlDataReader Reader = Parametreille.ExecuteReader();
                while (Reader.Read())
                {
                    LaskuRaportti haeLaskuRaportit = new LaskuRaportti(int.Parse(Reader[0].ToString()), int.Parse(Reader[1].ToString()), double.Parse(Reader[2].ToString()), double.Parse(Reader[3].ToString()), int.Parse(Reader[4].ToString()));
                    LaskuRaportit.Add(haeLaskuRaportit);
                }
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            return LaskuRaportit;
        }
        public static List<Lasku> getLasku()
        {
            Laskut.Clear();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  lasku ";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Lasku haeLasku = new Lasku(int.Parse(Reader[0].ToString()), int.Parse(Reader[1].ToString()), double.Parse(Reader[2].ToString()), double.Parse(Reader[3].ToString()), int.Parse(Reader[4].ToString()));
                    Laskut.Add(haeLasku);
                }
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            return Laskut;
        }

        public static void RemoveLasku(int i)
        {
            //Lasku = new List<Lasku>();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "DELETE FROM lasku WHERE lasku_id = " + i;
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            //return laskuuuuuuuuuuuuuuuuuuu;
        }
        public static void UusiLasku(Lasku oo)  //  Uusi lasku toiminto
        {

            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "INSERT INTO lasku(lasku_id,varaus_id,summa,alv,Maksettu) VALUES " +
                    "(NULL,'" + oo.VarausID1 + "','" + oo.Summa + "','" + oo.Alv + "','" + oo.maksettu + "')";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }

        }
        public static void UpdateLasku(Lasku oo) // laskun muokkaus hommelisysteemi
        {

            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "UPDATE lasku SET varaus_id = @varaus_id , summa = @summa , alv = @alv , Maksettu = @maksettu WHERE lasku_id = @lasku_id ";
                MySqlCommand Parametreille = new MySqlCommand(sql, connect);

                Parametreille.Parameters.Add("@lasku_id", MySqlDbType.Int32).Value = oo.LaskuID;
                Parametreille.Parameters.Add("@varaus_id", MySqlDbType.Int32).Value = oo.VarausID1;
                Parametreille.Parameters.Add("@summa", MySqlDbType.Double).Value = oo.Summa;
                Parametreille.Parameters.Add("@alv", MySqlDbType.Double).Value = oo.Alv;
                Parametreille.Parameters.Add("@maksettu", MySqlDbType.Int32).Value = oo.maksettu;

                Parametreille.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }


        }


        /* Varausten Tietokanta haut*/
        public static List<Varaus> getVaraus()
        {
            Varaukset.Clear();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  varaus ";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Varaus haeVaraukset = new Varaus(int.Parse(Reader[0].ToString()), int.Parse(Reader[1].ToString()), int.Parse(Reader[2].ToString()), int.Parse(Reader[3].ToString()), Convert.ToDateTime(Reader[4].ToString()), Convert.ToDateTime(Reader[5].ToString()), Convert.ToDateTime(Reader[6].ToString()));




                    Varaukset.Add(haeVaraukset);
                }
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            return Varaukset;
        }
        public static Varaus getCurrVaraus(int i) 
        {
            Varaus ValittuVaraus = null;
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  varaus WHERE varaus_id = " + i;
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    ValittuVaraus = new Varaus(int.Parse(Reader[0].ToString()), int.Parse(Reader[1].ToString()), int.Parse(Reader[2].ToString()), int.Parse(Reader[3].ToString()), Convert.ToDateTime(Reader[4].ToString()), Convert.ToDateTime(Reader[5].ToString()), Convert.ToDateTime(Reader[6].ToString()));
                }
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            return ValittuVaraus;
        }
        public static void SetVaraus(Varaus v) 
        {

            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "INSERT INTO varaus (varaus_id,asiakas_id,mokki_mokki_id,varattu_pvm,vahvistus_pvm,varattu_alkupvm,varattu_loppupvm) VALUES " +
                    "(@varaus_id,@asiakas_id,@mokkiid,@varattu_pvm,@vahvistus_pvm,@varattu_alkupvm,@varattu_loppupvm)";

                MySqlCommand cmd = new MySqlCommand(sql, connect);
                cmd.Parameters.Add("@varaus_id", MySqlDbType.Int32).Value = default;
                cmd.Parameters.Add("@asiakas_id", MySqlDbType.Int32).Value = v.AsiakasID1;
                cmd.Parameters.Add("@mokkiid", MySqlDbType.Int32).Value = v.MokkiID;
                cmd.Parameters.Add("@varattu_pvm", MySqlDbType.Int32).Value = v.VarattuPvm;
                cmd.Parameters.Add("@vahvistus_pvm", MySqlDbType.DateTime).Value = v.VahvistettuPvm;
                cmd.Parameters.Add("@varattu_alkupvm", MySqlDbType.DateTime).Value = v.VarattuAlku;
                cmd.Parameters.Add("@varattu_loppupvm", MySqlDbType.DateTime).Value = v.VarattuLoppu;
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }

        }
        public static void SetMuokattuVaraus(Varaus v)  
        {

            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();

                string sql = "UPDATE varaus SET varaus_id = @varaus_id, asiakas_id = @asiakas_id, mokki_mokki_id = @mokkiid, varattu_pvm = @varattu_pvm, vahvistus_pvm = @vahvistus_pvm, varattu_alkupvm = @varattu_alkupvm, varattu_loppupvm = @varattu_loppupvm WHERE varaus_id = @varaus_id";

                MySqlCommand cmd = new MySqlCommand(sql, connect);
                cmd.Parameters.Add("@varaus_id", MySqlDbType.Int32).Value = v.VarausID;
                cmd.Parameters.Add("@asiakas_id", MySqlDbType.Int32).Value = v.AsiakasID1;
                cmd.Parameters.Add("@mokkiid", MySqlDbType.Int32).Value = v.MokkiID;
                cmd.Parameters.Add("@varattu_pvm", MySqlDbType.Int32).Value = v.VarattuPvm;
                cmd.Parameters.Add("@vahvistus_pvm", MySqlDbType.DateTime).Value = v.VahvistettuPvm;
                cmd.Parameters.Add("@varattu_alkupvm", MySqlDbType.DateTime).Value = v.VarattuAlku;
                cmd.Parameters.Add("@varattu_loppupvm", MySqlDbType.DateTime).Value = v.VarattuLoppu;
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }

        }
        public static List<Varaustiedot> getVarausAsiakkaan(int i) 
        {
            VarausienTiedot.Clear();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  varaukset WHERE asiakas_id = " + i;
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Varaustiedot haeVaraukset = new Varaustiedot(int.Parse(Reader[0].ToString()), Reader[1].ToString(), int.Parse(Reader[2].ToString()), int.Parse(Reader[3].ToString()), Reader[4].ToString(), Reader[5].ToString(), Reader[6].ToString(), DateTime.Parse(Reader[7].ToString()), DateTime.Parse(Reader[8].ToString()), double.Parse(Reader[9].ToString()));
                    VarausienTiedot.Add(haeVaraukset);
                }
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            return VarausienTiedot;
        }
        public static void SetVarauksenPalvelut(PalvelutVaraukseen pv) 
        {

            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "INSERT INTO varauksen_palvelut(varaus_id,palvelu_id,lkm) VALUES " +
                    "(" + pv.VarausID + "," + pv.PalveluID + "," + pv.Lkm + ")";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }

        }
        public static void UpdateVarauksenPalvelut(PalvelutVaraukseen pv)  
        {

            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "UPDATE varauksen_palvelut SET varaus_id = @Varaus ,palvelu_id = @Palvelu,lkm = @lkm WHERE varaus_id = @Varaus AND palvelu_id = @Palvelu";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                cmd.Parameters.Add("@Varaus", MySqlDbType.Int32).Value = pv.VarausID;
                cmd.Parameters.Add("@Palvelu", MySqlDbType.Int32).Value = pv.PalveluID;
                cmd.Parameters.Add("@lkm", MySqlDbType.Int32).Value = pv.Lkm;
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }

        }
        public static void RemoveVarauksenPalvelut(PalvelutVaraukseen pv) 
        {

            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "DELETE FROM varauksen_palvelut WHERE varaus_id = @Varaus AND palvelu_id = @Palvelu";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                cmd.Parameters.Add("@Varaus", MySqlDbType.Int32).Value = pv.VarausID;
                cmd.Parameters.Add("@Palvelu", MySqlDbType.Int32).Value = pv.PalveluID;
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }

        }
        public static List<PalvelutVaraukseen> GetVarauksenPalvelut(int i)  
        {
            PalveluidenlisVar.Clear();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  palvelutvaraukseen WHERE varaus_id = " + i;
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    PalvelutVaraukseen palvelu = new PalvelutVaraukseen(int.Parse(Reader[0].ToString()), int.Parse(Reader[1].ToString()), int.Parse(Reader[2].ToString()), (Reader[3].ToString()));
                    PalveluidenlisVar.Add(palvelu);
                }
                Reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            return PalveluidenlisVar;
        }
        public static void RemoveVaraus(int i)
        {
            asiakkaat = new List<Asiakas>();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "DELETE FROM varaus WHERE varaus_id = " + i;
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            
        }
        public static int GetLastVarausID()
        {
            int ID = 0;
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT MAX(varaus_id) FROM  varaus ";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    ID = int.Parse(Reader[0].ToString());
                }
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }


            return ID;
        }


        //Palvelut

        public static List<PalveluRaportti> getPalveluRaportti(int p, DateTime a, DateTime l) // Ei toimi
        {
            PalveluRaportit.Clear();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  palveluRaportti WHERE palvelu_id = @palvelu AND vahvistus_pvm > @alku AND vahvistus_pvm < @loppu";
                MySqlCommand Parametreille = new MySqlCommand(sql, connect);
                Parametreille.Parameters.Add("@palvelu", MySqlDbType.Int32).Value = p;
                Parametreille.Parameters.Add("@alku", MySqlDbType.DateTime).Value = a;
                Parametreille.Parameters.Add("@loppu", MySqlDbType.DateTime).Value = l;
                MySqlDataReader Reader = Parametreille.ExecuteReader();
                while (Reader.Read())
                {
                    PalveluRaportti haeparaportti = new PalveluRaportti(int.Parse(Reader[0].ToString()), Reader[1].ToString(), double.Parse(Reader[2].ToString()), double.Parse(Reader[3].ToString()), int.Parse(Reader[4].ToString()), DateTime.Parse(Reader[5].ToString()), DateTime.Parse(Reader[6].ToString()), DateTime.Parse(Reader[7].ToString()));
                    PalveluRaportit.Add(haeparaportti);
                }
                Reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
            return PalveluRaportit;
        }
        public static void RemovePalvelu(int i)
        {
            palvelut = new List<Palvelu>();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "DELETE FROM palvelu WHERE palvelu_id = " + i;
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }

        }

        public static void setPalvelu(Palvelu p)
        {
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "INSERT INTO palvelu (palvelu_id,toimintaalue_id,nimi,tyyppi,kuvaus,hinta,alv) VALUES " +
                    "(@palvelu_id,@toimialue_id,@nimi,@tyyppi,@kuvaus,@hinta,@alv)";

                MySqlCommand cmd = new MySqlCommand(sql, connect);
                cmd.Parameters.Add("@palvelu_id", MySqlDbType.Int32).Value = default;
                cmd.Parameters.Add("@toimialue_id", MySqlDbType.Int32).Value = p.ToimintaalueID1;
                cmd.Parameters.Add("@nimi", MySqlDbType.VarChar).Value = p.Nimi;
                cmd.Parameters.Add("@tyyppi", MySqlDbType.Int32).Value = p.Tyyppi;
                cmd.Parameters.Add("@kuvaus", MySqlDbType.VarChar).Value = p.Kuvaus;
                cmd.Parameters.Add("@hinta", MySqlDbType.Decimal).Value = p.Hinta;
                cmd.Parameters.Add("@alv", MySqlDbType.Decimal).Value = p.Alv;
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
        }
        public static void UpdatePalvelu(Palvelu p)
        {
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "UPDATE palvelu SET toimintaalue_id = @toimialue , nimi = @nimi , " +
                    "tyyppi = @tyyppi , kuvaus = '@kuvaus' , hinta = @hinta , alv = @alv WHERE palvelu_id = @palvelu_id";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                cmd.Parameters.Add("@palvelu_id", MySqlDbType.Int32).Value = p.PalveluID;
                cmd.Parameters.Add("@toimialue", MySqlDbType.Int32).Value = p.ToimintaalueID1;
                cmd.Parameters.Add("@nimi", MySqlDbType.VarChar).Value = p.Nimi;
                cmd.Parameters.Add("@tyyppi", MySqlDbType.Int32).Value = p.Tyyppi;
                cmd.Parameters.Add("@kuvaus", MySqlDbType.VarChar).Value = p.Kuvaus;
                cmd.Parameters.Add("@hinta", MySqlDbType.Double).Value = p.Hinta;
                cmd.Parameters.Add("@alv", MySqlDbType.Double).Value = p.Alv;

                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
                connect = null;
            }
        }
       
        
    }
}
