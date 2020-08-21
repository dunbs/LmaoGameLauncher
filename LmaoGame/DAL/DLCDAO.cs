using LmaoGame;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjectPRN_DAOTesting.DAL
{
    class DLCDAO
    {
        public DataTable GetDLCbyGameid(int gameid)
        {
            String sql = @"Select *, FORMAT(price, 'C') as 'price2', iif(o.userid is null, '', 'Owned') as 'isOwned'
from DLC d
LEFT JOIN ownDLC o ON d.id = o.DLCid and o.userid = @userid
where d.gameid = @id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@id", gameid);
            cmd.Parameters.AddWithValue("@userid", UserControl.User?.Id == null ? -1 : UserControl.User?.Id);
            return DAO.GetDataTable(cmd);
        }

        public bool AddDLC(int dlcId, int userId)
        {
            string sql = @"INSERT INTO [dbo].[ownDLC]
           ([userid]
           ,[DLCid])
     VALUES
           (@userId
           ,@dlcId)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@dlcId", dlcId);
            return DAO.UpdateTable(cmd);
        }

        public DataTable getDLCWithUserid(int gameid, int userid)
        {
            String sql = @"SELECT d.*, iif(userid is null, 'not owned','owned') as 'status'
    from DLC as d left join(select* from ownDLC where userid = @userid) as o
    on d.id = o.DLCid where gameid = @gameid";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@gameid", gameid);
            cmd.Parameters.AddWithValue("@userid", userid);
            return DAO.GetDataTable(cmd);
        }
    }
}
