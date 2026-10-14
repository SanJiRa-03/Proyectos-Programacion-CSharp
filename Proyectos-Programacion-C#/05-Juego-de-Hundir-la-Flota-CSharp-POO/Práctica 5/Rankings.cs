using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica2
{
    public class Rankings
    {

        private string NameP1;
        private string NameP2;
        private int NumMovements;
        private string Winner;


        public Rankings() { }
        public Rankings(string NameP1, string NameP2, int NumMovements, string Winner)
        {
            this.NameP1 = NameP1;
            this.NameP2 = NameP2;
            this.NumMovements = NumMovements;
            this.Winner = Winner;
        }


        //MUTATORS
        public void SetNameP1(string NameP1)
        {
            this.NameP1 = NameP1;
        }
        public void SetNameP2(string NameP2)
        {
            this.NameP2 = NameP2;
        }
        public void SetNumMovements(int NumMovements)
        {
            this.NumMovements = NumMovements;
        }
        public void SetWinner(string Winner)
        {
            this.Winner = Winner;
        }

        //ACCESORS
        public string GetNameP1()
        {
            return NameP1;
        }
        public string GetNameP2()
        {
            return NameP2;
        }
        public int GetNumMovements()
        {
            return NumMovements;
        }
        public string GetWinner()
        {
            return Winner;
        }



        //----------------------------------------------------------------------------------------------------------------------------

        public List<Rankings> rankings = new List<Rankings>();

        //constructor
        public Rankings(List<Rankings> rankings)
        {
            this.rankings = rankings;
        }

        public List<Rankings> GetRankings()
        {
            return rankings;
        }

        public void SetRankings(List<Rankings> rankings)
        {
            this.rankings = rankings;
        }


        //functions
        public void AddGame(Rankings r)
        {
            rankings.Add(r);
        }

        public void FileRanking()
        {
            var path1 = "../../rankings.txt";
            char separator = ';';
            StreamWriter sw1 = File.CreateText(path1);
            foreach (Rankings r in rankings)
            {
                if (r.GetWinner() == r.GetNameP1())
                {
                    sw1.WriteLine("P1" + separator + r.GetNameP1() + separator + r.GetNumMovements() + separator + "P2" + separator + r.GetNameP2());

                }
                else
                {
                    sw1.WriteLine("P2" + separator + r.GetNameP2() + separator + r.GetNumMovements() + separator + "P1" + separator + r.GetNameP1());

                }

            }
            sw1.Close();
        }

        public void ExtractRanking()
        {
            var path1 = "../../rankings.txt";

            StreamReader sr1 = File.OpenText(path1);

            char separator = ';';

            string line1;

            while ((line1 = sr1.ReadLine()) != null)
            {

                string[] value = line1.Split(separator);
                if (value.Length >= 4 && value[0] == "P1")
                {
                    Rankings rank = new Rankings(value[1], value[3], int.Parse(value[2]), value[1]);
                    rankings.Add(rank);
                }
                else if (value.Length >= 4)
                {
                    Rankings rank = new Rankings(value[3], value[1], int.Parse(value[2]), value[1]);
                    rankings.Add(rank);
                }
            }
            sr1.Close();
        }

        public void WriteRanking()
        {
            rankings.OrderByDescending(x => x.GetNumMovements()); //Esto ordenará los rankings por El numero de movimmientos de mayor a menor
            rankings.Reverse(); //Y asi se ordenará al revés

            foreach (Rankings r in rankings)
            {
                //Esto se va a ordenar por
                if (r.GetWinner() == r.GetNameP1())
                {
                    Console.WriteLine("GANADOR:  " + r.GetNameP1() + "\t Moves:  " + r.GetNumMovements());
                    Console.WriteLine("PERDEDOR:  " + r.GetNameP2());
                }
                else if (r.GetWinner() == r.GetNameP2())
                {
                    Console.WriteLine("GANADOR:  " + r.GetNameP2() + "\t Moves:  " + r.GetNumMovements());
                    Console.WriteLine("PERDEDOR:  " + r.GetNameP1());
                }
            }

        }


        
    }
}