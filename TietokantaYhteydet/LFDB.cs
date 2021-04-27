using Hotel.Oliot;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    
    class LFDB
    {
        public static MySqlConnection connect = null;
        public static List<mokki> mokit = new List<mokki>();
        public static List<Asiakas> asiakkaat = new List<Asiakas>();
        public static List<Palvelu> palvelut = new List<Palvelu>();
        public static List<Lasku> Laskut = new List<Lasku>();
        public static List<Toimialue> toimintaalueet = new List<Toimialue>();
        public static List<Varaus> Varaukset = new List<Varaus>();
        public static List<MokkiRaportti> MokkiRaportit = new List<MokkiRaportti>();
        
        static string myConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=Ruutti;database=vn;port=3307";
        public static List<mokki> getMokit() {

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
                        mokki haemokit = new mokki(int.Parse(Reader[0].ToString()), int.Parse(Reader[1].ToString()), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString(), Reader[5].ToString(), int.Parse(Reader[6].ToString()),Reader[7].ToString(), double.Parse(Reader[8].ToString()));
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
        public static List<MokkiRaportti> getMokkiRaportti(string s ,DateTime a,DateTime l)
        {
            ///////////// ONGELMA PÄIVÄN KANSSA!
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  raportti where mokkinimi="+s+" AND varattu_alkpvm >"+a+" AND varattu_loppupvm <"+l;
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    MokkiRaportti haeraportti = new MokkiRaportti(int.Parse(Reader[0].ToString()), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString(), DateTime.Parse(Reader[4].ToString()), DateTime.Parse(Reader[5].ToString()), double.Parse(Reader[6].ToString()));
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
        public static List<Toimialue> GetToimialue()
        {

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
                    Toimialue haealueet = new Toimialue(int.Parse(Reader[0].ToString()),Reader[1].ToString());
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
        public static void SetToimialue(int i, string s)
        {
            int affect = 0;
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "INSERT INTO toimintaalue(toimintaalue_id,nimi) VALUES ( "+ i +",'"+s+"');";
                MySqlCommand cmd = new MySqlCommand(sql, connect);

                cmd.Parameters.Add(i.ToString(), MySqlDbType.Int64).Value = i;
                cmd.Parameters.Add(s, MySqlDbType.VarChar).Value = s;
                affect = cmd.ExecuteNonQuery();
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
            int affect = 0;
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "DELETE FROM toimintaalue WHERE toimintaalue_id=" + i;
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                affect = cmd.ExecuteNonQuery();
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
            int affect = 0;
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "UPDATE toimintaalue SET nimi='" + s + "' WHERE toimintaalue_id="+i;
                MySqlCommand cmd = new MySqlCommand(sql, connect);

                affect = cmd.ExecuteNonQuery();

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
        public static List<Palvelu> getPalvelut()
        {

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
        public static List<Asiakas> getAsiakas()
        {

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
        public static List<Lasku> getLasku()
        {

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
                    Lasku haeLasku = new Lasku(int.Parse(Reader[0].ToString()), int.Parse(Reader[1].ToString()), double.Parse(Reader[2].ToString()), double.Parse(Reader[3].ToString()));
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
        public static List<Varaus> getVaraus()
        {

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
                    Varaus haeVaraukset = new Varaus(int.Parse(Reader[0].ToString()), int.Parse(Reader[1].ToString()), int.Parse(Reader[2].ToString()), DateTime.Parse(Reader[3].ToString()), DateTime.Parse(Reader[4].ToString()),DateTime.Parse(Reader[5].ToString()), DateTime.Parse(Reader[6].ToString()));
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
        public static List<mokki> getMokitToiauleittain(int i)
        {
            mokit = new List<mokki>();
            try
            {
                if (connect == null)
                    connect = new MySqlConnection();
                connect.ConnectionString = myConnectionString;
                connect.Open();
                string sql = "SELECT * FROM  mokki WHERE toimintaalue_id = " +i;
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
        public static List<mokki> deleteMokki(int i)
        {
            mokit = new List<mokki>();
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
    }
}
