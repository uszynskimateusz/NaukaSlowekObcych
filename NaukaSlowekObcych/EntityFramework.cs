using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace NaukaSlowekObcych
{
    class EntityFramework : DatabaseFacade
    {
        string sqlConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security = True";
        public void addWord(Word word)
        {
            using (SqlConnection conn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO Word(polish,english) VALUES(@param,@param2)";

                    cmd.Parameters.AddWithValue("@param", word.polish);
                    cmd.Parameters.AddWithValue("@param2", word.english);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.Message.ToString(), "Error Message");
                    }
                }
            }
        }

        public void editWord(Word word, Word editWord)
        {
            using (SqlConnection conn = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"UPDATE Word SET polish = @param, english = @param2 Where polish = @param3 and english = @param4";

                    cmd.Parameters.AddWithValue("@param", editWord.polish);
                    cmd.Parameters.AddWithValue("@param2", editWord.english);
                    cmd.Parameters.AddWithValue("@param3", word.polish);
                    cmd.Parameters.AddWithValue("@param4", word.english);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.Message.ToString(), "Error Message");
                    }

                }
            }
        }

        public List<Word> getWords()
        {
            List<Word> words = new List<Word>();
            SqlConnection con = new SqlConnection(sqlConnectionString);
            string sql = "SELECT * FROM Word";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Word newWord = new Word(reader["polish"].ToString(), reader["english"].ToString());
                words.Add(newWord);
            }
            reader.Close(); con.Close();

            return words;
        }

        public void removeWord(Word word)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(sqlConnectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM Word WHERE polish = '" + word.polish + "' AND english = '" + word.english + "'", con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }
    }
}
