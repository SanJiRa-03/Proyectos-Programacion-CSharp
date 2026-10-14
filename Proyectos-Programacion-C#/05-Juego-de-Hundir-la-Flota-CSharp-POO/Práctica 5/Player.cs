using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public abstract class Player
    {
        //ATTRIBUTES
        protected string Name;
        protected int NumMovements;
        protected int Winner;


        // MUTATORS AND ACCESSORS OF THE ATTRIBUTES

        public string GetName()
        {
            return Name;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public int GetWinner()
        {
            return this.Winner;
        }
        public void SetWinner(int winner)
        {
            this.Winner = winner;
        }

        public int GetNumMovements()
        {
            return this.NumMovements;
        }
        public void SetNumMovements(int NumMovements)
        {
            this.NumMovements = NumMovements;
        }
        
        public Player()
        {

        }
        
        public Player(string Name)
        {
            this.Name = Name;
            this.NumMovements = 0;
            this.Winner = 0;
        }
        public Player(string Name, int NumMovements, int Winner)
        {
            this.Name = Name;
            this.NumMovements = 0;
            this.Winner = 0;
        }


        //FUNCTION
        public abstract void PlaceShips(ref BoardGame board);

        public string GetFileSaveString()
        {
            return $"{Name}_{NumMovements}_{Winner}";
        }
    }
}



