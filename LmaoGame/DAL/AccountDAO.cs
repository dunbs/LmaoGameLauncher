using ProjectPRN_DAOTesting.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectPRN_DAOTesting.DAL
{
    class AccountDAO
    {
        public Account Login(String username, String password)
        {
            String sql = "SELECT * FROM [Account] WHERE [username] = @username and [password] = @password";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            DataTable dataTable = DAO.GetDataTable(command);

            if (dataTable.Rows.Count <= 0) return null;

            DataRow row = dataTable.Rows[0];
            Account account = new Account();
            account.Id = (int)row["id"];
            account.Username = (String)row["username"];
            account.Password = (String)row["password"];
            account.Name = (String)row["name"];
            account.Email = (String)row["email"];
            account.Image = (Image)(row["image"] == null ? row["image"] : Image.FromStream(new MemoryStream((byte[])row["image"])));
            return account;

        }

        public bool Register(String username, String password, String name, String email, Image image)
        {
            String sql = "INSERT INTO [dbo].[Account] ([username],[password],[name],[email],[image]) VALUES (@username,@password,@name,@email,@image)";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@image", ConvertImageToByteArray(image, image.RawFormat));
            return DAO.UpdateTable(command);
        }

        public bool EditProfile(Account account)
        {
            String sql = "UPDATE[Account]\n"
                            + "SET[password] = @password,[name] = @name,[email] = @email,[image] = @image\n"
                            + "WHERE [id] = @userid\n";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@userid", account.Id);
            cmd.Parameters.AddWithValue("@password", account.Password);
            cmd.Parameters.AddWithValue("@name", account.Name);
            cmd.Parameters.AddWithValue("@email", account.Email);
            cmd.Parameters.AddWithValue("@image", ConvertImageToByteArray(account.Image, account.Image.RawFormat));
            return DAO.UpdateTable(cmd);
        }

        public Account GetAccount(String username)
        {
            String sql = "Select * from Account where username = @username";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@username", username);
            DataTable table = DAO.GetDataTable(cmd);
            if (table == null || table.Rows.Count == 0) return null;
            DataRow row = table.Rows[0];
            Account account = new Account();
            account.Id = (int)row["id"];
            account.Username = (String)row["username"];
            account.Password = (String)row["password"];
            account.Name = (String)row["name"];
            account.Email = (String)row["email"];
            account.Image = Image.FromStream(new MemoryStream((byte[])row["image"]));
            return account;
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
