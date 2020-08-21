using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ProjectPRN_DAOTesting.model
{
    public class Game
    {
        int id;
        String name;
        Image image;
        Gerne gerne;
        decimal price;
        DateTime releaseDate;
        int access;
        String description;
        bool isOwned;
        float reviewScore;

        public string Description { get => description; set => description = value; }
        public int Access { get => access; set => access = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public Image Image { get => image; set => image = value; }
        public bool IsOwned { get => isOwned; set => isOwned = value; }
        public decimal Price { get => price; set => price = value; }
        public float ReviewScore { get => reviewScore; set => reviewScore = value; }
        internal Gerne Gerne { get => gerne; set => gerne = value; }
    }
}
