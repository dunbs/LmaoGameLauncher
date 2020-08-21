using LmaoGame.Common;
using ProjectPRN_DAOTesting.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace ProjectPRN_DAOTesting.DAL
{
    class GameDAO
    {
        public readonly string REALEASE_DATE = "releaseDate";
        public readonly string PRICE = "price";
        public readonly string NAME = "name";
        public readonly string REVIEW = "avg";

        public int getMaxPage(int userid, String gameName, bool isOwned, List<int> gernes)
        {
            string sql =
$@"Select count(*) from 
	(SELECT 
    ga.[id]
	,ga.[name]
	,[image]
	,[gerneid]
	,ge.[name] as 'genreName'
	,[price]
	,[releaseDate]
	,[access]
	,[description]
	,re.[avg]
	,iif(l.userid is null, cast(0 as bit),cast(1 as bit)) as 'owned'
	FROM [Game] ga left join [Genre] ge
	on ga.gerneid = ge.id
	left join 
	(select r.gameid , AVG(r.rating) as 'avg'
		from Rating r group by r.gameid) as re 
	on re.gameid = ga.id
	{(isOwned ? "right" : "left")} join (select * from Library where userid = @userid) as l
    on l.gameid = ga.id
    Where ga.[name] like @gameName ";

            if (gernes.Count >= 1)
            {
                sql += "and (";
                foreach (int gerneid in gernes)
                {
                    sql += " gerneid = " + gerneid + " or ";
                }
                sql = sql.Remove(sql.Length - 3);
                sql += ")";
            }
            sql += ") as x";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@gameName", '%' + gameName + '%');
            return Convert.ToInt32(DAO.GetDataTable(cmd)?.Rows[0][0]);
        }

        public List<Game> GetGamePage(int userid, int size, int page, String gameName, Dictionary<String, bool> attributes, bool isOwned, List<int> gernes)
        {
            String sql = @"Select * from 
	(SELECT "
    + "\nROW_NUMBER() over(order by ";
            foreach (KeyValuePair<String, bool> pair in attributes)
            {
                sql += $"{(pair.Key == LmaoConstant.NAME ? "ga." : "")}[{pair.Key}]" + " " + (pair.Value ? "asc" : "desc") + " ,";
            }
            sql = sql.Remove(sql.Length - 1);
            sql += ") as rownum\n"
    + $@"   ,ga.[id]
	,ga.[name]
	,[image]
	,[gerneid]
	,ge.[name] as 'genreName'
	,[price]
	,[releaseDate]
	,[access]
	,[description]
	,re.[avg]
	,iif(l.userid is null, cast(0 as bit),cast(1 as bit)) as 'owned'
	FROM [Game] ga left join [Genre] ge
	on ga.gerneid = ge.id
	left join 
	(select r.gameid , AVG(cast(r.rating as float)) as 'avg'
		from Rating r group by r.gameid) as re 
	on re.gameid = ga.id
	{(isOwned ? "right" : "left")} join (select * from Library where userid = @userid) as l
	on l.gameid = ga.id
    Where ga.[name] like @gameName ";
            if (gernes.Count >= 1)
            {
                sql += "and (";
                foreach (int gerneid in gernes)
                {
                    sql += " gerneid = " + gerneid + " or ";
                }
                sql = sql.Remove(sql.Length - 3);
                sql += ")";
            }
            sql += @") as x 
	where rownum between @begin and @end";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@gameName", $"%{gameName}%");
            cmd.Parameters.AddWithValue("@begin", size * page - (size - 1));
            cmd.Parameters.AddWithValue("@end", size * (page));
            DataTable table = DAO.GetDataTable(cmd);
            List<Game> games = new List<Game>();
            if (table == null) return games;
            foreach (DataRow row in table.Rows)
            {
                Game game = new Game();
                game.Id = (int)row["id"];
                game.Name = (String)row["name"];
                game.Image = row["image"] != System.DBNull.Value ? Image.FromStream(new MemoryStream((byte[])row["image"])) : null;
                game.Price = (decimal)row["price"];
                game.ReleaseDate = (DateTime)row["releaseDate"];
                game.Access = (int)row["access"];
                game.Description = (String)row["description"];
                Gerne gerne = new Gerne();
                gerne.Id = (int)row["gerneid"];
                gerne.Name = (String)row["genreName"];
                game.Gerne = gerne;
                game.ReviewScore = row["avg"] != System.DBNull.Value ? float.Parse(row["avg"].ToString()) : -1;
                game.IsOwned = (bool)row["owned"];
                games.Add(game);
            }
            return games;
        }

        public Game GetGameByID(int gameid, int userid)
        {
            String sql = @"SELECT 
	ga.[id]
	,ga.[name]
	,[image]
	,[gerneid]
	,ge.[name] as 'genreName'
	,[price]
	,[releaseDate]
	,[access]
	,[description]
	,re.[avg]
	,iif(l.userid is null, cast(0 as bit),cast(1 as bit)) as 'owned'
	FROM [Game] ga left join [Genre] ge
	on ga.gerneid = ge.id
	left join 
	(select r.gameid , AVG(cast(r.rating as float)) as 'avg'
		from Rating r group by r.gameid) as re 
	on re.gameid = ga.id
	left join (select * from Library where userid = @userid) as l
	on l.gameid = ga.id 
	Where ga.id = @gameid";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@gameid", gameid);
            DataRow row = DAO.GetDataTable(cmd).Rows[0];
            Game game = new Game();
            game.Id = (int)row["id"];
            game.Name = (String)row["name"];
            game.Image = row["image"] != System.DBNull.Value ? Image.FromStream(new MemoryStream((byte[])row["image"])) : null;
            game.Price = (decimal)row["price"];
            game.ReleaseDate = (DateTime)row["releaseDate"];
            game.Access = (int)row["access"];
            game.Description = (String)row["description"];
            Gerne gerne = new Gerne();
            gerne.Id = (int)row["gerneid"];
            gerne.Name = (String)row["genreName"];
            game.Gerne = gerne;
            game.ReviewScore = row["avg"] != System.DBNull.Value ? float.Parse(row["avg"].ToString()) : -1;
            game.IsOwned = (bool)row["owned"];
            return game;
        }

        public bool BuyGame(int userid, int gameid)
        {
            String sql = "INSERT INTO [dbo].[Library] ([userid],[gameid]) VALUES (@userid,@gameid)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@gameid", gameid);
            return DAO.UpdateTable(cmd);
        }

        public bool Rating(int userid, int gameid, int score)
        {
            String sql = @"INSERT INTO [dbo].[Rating]
           ([gameid]
           ,[usertid]
           ,[rating])
     VALUES
           (@gameid
           , @userid
           , @score)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@gameid", gameid);
            cmd.Parameters.AddWithValue("@score", score);
            return DAO.UpdateTable(cmd);
        }

        public bool EditRating(int userid, int gameid, int score)
        {
            String sql = @"UPDATE [dbo].[Rating]
   SET [rating] = @score
 WHERE  [gameid] = @gameid
      and [usertid] = @userid";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@gameid", gameid);
            cmd.Parameters.AddWithValue("@score", score);
            return DAO.UpdateTable(cmd);
        }

        public bool InsertGame(Game game)
        {
            String sql = @"INSERT INTO [dbo].[Game]
           ([name]
           ,[image]
           ,[gerneid]
           ,[price]
           ,[releaseDate]
           ,[access]
           ,[description])
     VALUES
           (@name
           , @image
           , @gerneid
           , @price
           , @releaseDate
           , @access
           , @description)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@name", game.Name);
            cmd.Parameters.AddWithValue("@image", ConvertImageToByteArray(game.Image, game.Image.RawFormat));
            cmd.Parameters.AddWithValue("@gerneid", game.Gerne.Id);
            cmd.Parameters.AddWithValue("@price", game.Price);
            cmd.Parameters.AddWithValue("@releaseDate", game.ReleaseDate);
            cmd.Parameters.AddWithValue("@access", 0);
            cmd.Parameters.AddWithValue("@description", game.Description);
            return DAO.UpdateTable(cmd);
        }

        public bool AddAccess(int gameid)
        {
            String sql = @"UPDATE [dbo].[Game]
   SET[access] = [access] + 1
 WHERE[id] = @gameid";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@gameid", gameid);
            return DAO.UpdateTable(cmd);
        }

        public int? GetRatingByUser(int? userid, int gameid)
        {
            String sql = @"SELECT [rating]
  FROM [Rating]
  Where [usertid] = @usertid
  and [gameid] = @gameid";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@usertid", userid);
            cmd.Parameters.AddWithValue("@gameid", gameid);
            try
            {
                return int.Parse(DAO.GetDataTable(cmd).Rows[0][0].ToString());
            }
            catch
            {
                return 0;
            }
        }

        private byte[] ConvertImageToByteArray(System.Drawing.Image imageToConvert,
                                       System.Drawing.Imaging.ImageFormat formatOfImage)
        {
            byte[] Ret;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageToConvert.Save(ms, formatOfImage);
                    Ret = ms.ToArray();
                }
            }
            catch (Exception) { throw; }
            return Ret;
        }
    }
}
