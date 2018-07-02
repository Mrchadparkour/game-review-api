using System;
using System.IO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Newtonsoft.Json;
using game_review_api.Models;
using Dapper;

namespace game_review_api.DataProvider
{
    public class GameDb
    {
        internal static string ConnectionString = System.Environment.GetEnvironmentVariable("DB_CONNECT_DEV");
        public static void Init()
        {
            FileInfo file = new FileInfo("sqlScripts/initGameDb.sql");
            string sqlScript = file.OpenText().ReadToEnd();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                conn.Execute(sqlScript);
            }
        }
        public static void SearchByName(string name)
        {
            IEnumerable<Game> games = Query<Game>($"select name from information_schema.columns where name like '%{name}%'");
            foreach (Game game in games)
            {
                Console.WriteLine(game.Name);
            }
        }
        public static void CreateFromJSON(string path)
        {
            Init();
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                ScrapeResults results = JsonConvert.DeserializeObject<ScrapeResults>(json);
                foreach (Game game in results.games)
                {
                    Execute(@"insert into games (name, score, oneword, description, url) values (@Name, @Score, @Oneword, @Description, @Url)", game);
                }
            }
        }
        internal static IEnumerable<T> Query<T>(string sql, object param = null)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                return conn.Query<T>(sql, param);
            }
        }
        internal static int Execute(string sql, object param = null)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                return conn.Execute(sql, param);
            }
        }
    }
}