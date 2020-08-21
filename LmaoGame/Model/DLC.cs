using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPRN_DAOTesting.model
{
    class DLC
    {
        int gameid;
        int id;
        String name;
        double price;
        DateTime releaseDate;
        int sales;

        public int Sales { get => sales; set => sales = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public double Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int Gameid { get => gameid; set => gameid = value; }
    }
}
