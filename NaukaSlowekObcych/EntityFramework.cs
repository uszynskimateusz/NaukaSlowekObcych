using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NaukaSlowekObcych
{
    class EntityFramework : DatabaseFacade
    {
        string sqlConnectionString = Properties.Settings.Default.WordStorageConnectionString;

        public void addWord()
        {
            SqlConnection con = new SqlConnection(sqlConnectionString);
            string sql = "SELECT * FROM Word";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["polish"].ToString() + " " + reader["english"].ToString());
                Console.WriteLine("-----------------------------------");
            }
            reader.Close(); con.Close();
        }

        public Word getRandomWord()
        {
            throw new NotImplementedException();
        }

        public void removeWord(Word word)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
