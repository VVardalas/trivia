using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    class Player
    {
        //Property
        private string name;
        private int place;
        private int purse;
        private bool inPenaltyBox;




        //Constructeur
        public Player(string name)
        {
            this.Name = name;
            this.Place = 0;
            this.Purse = 0;
            this.InPenaltyBox = false;
        }

        //Méthodes, getter/setter

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Place
        {
            get { return place; }
            set { place = value; }
        }

        public int Purse
        {
            get { return purse; }
            set { purse = value; }
        }

        public bool InPenaltyBox
        {
            get { return inPenaltyBox; }
            set { inPenaltyBox = value; }
        }
    }
}