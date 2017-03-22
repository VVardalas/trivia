using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    class Player
    {
        //Property
        private string _name;



        //Constructeur
        public Player(string name)
        {
            this.name = name;
        }

        //Méthodes

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}