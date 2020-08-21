using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ProjectPRN_DAOTesting.model
{
    class Account
    {
        int id;
        String username;
        String password;
        String name;
        String email;
        Image image;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public Image Image { get => image; set => image = value; }
    }
}
