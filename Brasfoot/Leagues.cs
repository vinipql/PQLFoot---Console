using System;
using System.Collections.Generic;
using System.Text;


namespace Brasfoot
{
    public class Leagues : Squad
    {
        private List<string> leagues = new List<string> { "Campeonato Brasileiro", "Copa Libertadores da America", "Copa do Brasil", "Copa Sul Americana", "Supercopa do Brasil", "Recopa", "Premier League", "Champions League", "Mundial de Clubes" };
        private List<string> teamsName = new List<string> { "Chelsea----------", "Manchester United", "Manchester City--", "Palmeiras--------", "Corinthians------", "Santos-----------", "São Paulo--------", "Flamengo---------", "Fluminense-------", "Vasco------------", "Gremio-----------", "Internacional----", "Cruzeiro---------", "Atletico-MG------", "Barcelona--------", "Real Madrid------", "Milan------------", "Juventus---------", "Internazionale---", "Bayern-----------", "Borussia Dortmund", "Boca Juniors-----", "River Plate------", "Liverpool--------", "Arsenal----------" };
        private string leagueName;
        private double leagueRating;
        private List<string> leagueRanking;
        

        public string getLeagueName()
        {
            return this.leagueName;
        }

        public void setLeagueName()
        {
            Random r = new Random();
            this.leagueName = leagues[r.Next(0, 8)];
        }

        public double getLeagueRating()
        {
            return this.leagueRating;
        }

        public void setLeagueRating()
        {
            Random r = new Random();
            double rNumber = r.Next() * (10 - 1) + 1;
            this.leagueRating = rNumber;
        }

        public List<string> getLeagueRanking()
        {
            return this.leagueRanking;
        }

        public void setLeagueRanking()
        {
            this.leagueRanking = ControyChampionship();
        }


        public Leagues()
        {
            setLeagueName();
            setLeagueRating();
            beginLeague();
            setLeagueRanking();
        }


        //metodo que monta lista com nomes dos times que disputarão o campeonato
        public List<string> beginLeague()
        {
            List<string> x = new List<string>();
            int teamsSize = teamsName.Count;
            int leagueSize = leagues.Count;
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                x.Add(teamsName[r.Next(0, teamsSize)]);
            }

            return x;
        }

        //metodo que pega um nome da lista dos times montada no metodo beginLeague() e adiciona na primeira posiçao de uma nova lista, as proximas 11 posicoes dessa lista sao de nomes de jogadores
        public List<string> defineLeague()
        {
            List<string> result = new List<string>();
            List<string> x = new List<string>();
            x = this.beginLeague();
            Random r = new Random();

            result.Add(x[r.Next(1,10)]);

            for(int i = 11; i>0; i--)
            {
                result.Add(names[r.Next(0, 2000)]);
            }

            return result;

        }

        //monta a lista gigante com todos os 10 times e todos seus jogadores
        public List<string> ControyChampionship()
        {
            List<string> x = new List<string>();
            List<string> result = new List<string>();
            

            for (int i = 11; i > 0; i--)
            {
                x = defineLeague();
                foreach (string element in x)
                {
                    result.Add(element);
                }
            }
            return result;
        }

        public void Table()
        {
            Console.Clear();
            string istring = "";
            int y = 0;
            List<string> x = new List<string>();
            x = getLeagueRanking();
            Console.Clear();

            Console.WriteLine($"TIMES----------------------| P | V | E | D | GP | GC | SG | %  |");
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine($"{x[y]}----------| 0 | 0 | 0 | 0 | 0  | 0  | 0  | 0  |");
                y += 12;
            }
        }


        public void orgazineTable()
        {
            Console.Clear();
            string OwnerName = Options.passOwnerName();
            var Table = new List<Table>();
            List<string> x = new List<string>();
            x = getLeagueRanking();
            int y = 0;

            Console.WriteLine($"TIMES----------------------| P | V | E | D | GP | GC | SG | %  |");
            Console.WriteLine($"{Options.passOwnerName()}----------| 0 | 0 | 0 | 0 | 0  | 0  | 0  | 0  |");

            for (int i = 0; i < 10; i++)
            {
                Table t = new Table();
                t.Team = x[y];
                y += 12;

                Table.Add(t);

                
            }
            foreach(var obj in Table)
            {
                Console.WriteLine($"{obj.Team}----------| 0 | 0 | 0 | 0 | 0  | 0  | 0  | 0  |");
            }






    }




    }
}
