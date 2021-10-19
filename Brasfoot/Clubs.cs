using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Brasfoot
{
    public class Clubs
    {

        //Definição de atributos
        private string ownerName;
        private string clubName;
        private int clubMoney;
        private string clubStadium;
        private int clubFans;
        private string clubContry;
        private double clubRating;

        //Encapsulamento dos atributos
        public void setOwnerName(string _ownerName)
        {
            this.ownerName = _ownerName;
        }
        public string getOwnerName()
        {
            return this.ownerName;
        }

        public string getClubName()
        {
            return this.clubName;
        }

        public void setClubName(string _clubName)
        {
            this.clubName = _clubName;
        }

        public int getMoney()
        {
            return this.clubMoney;
        }

        public void setMoney()
        {
            Random r = new Random();
            this.clubMoney = r.Next(100000, 50000000);
        }

        public string getStadium()
        {
            return this.clubStadium;
        }

        public void setStadium(string name)
        {
            this.clubStadium = name;
            
        }

        public int getFans()
        {
            return this.clubFans;
        }

        public void setFans()
        {
            Random r = new Random();
            this.clubFans = r.Next(1000000, 40000000);
        }

        public double getRating()
        {
            return this.clubRating;
        }

        public void setRating()
        {
            Random r = new Random();
            double rNumber = r.Next() * (10 - 1) + 1;
            this.clubRating = rNumber;
        }

        public string getCountry()
        {
            return this.clubContry;
        }

        public void setCountry()
        {

        }

        public Clubs()
        {
            setMoney();
            setStadium(this.clubName);
            setFans();
            setRating();
            setCountry();
        }


        public void showStatus()
        {

            CultureInfo elGr = CultureInfo.CreateSpecificCulture("el-GR");
            Console.Clear();
            string clubMoney = String.Format("{0:C2}", this.clubMoney);
            string clubFans = String.Format(elGr, "{0:0,0}", this.clubFans);

            string status = $"Olá, {this.ownerName}{Environment.NewLine}" +
                $"O seu clube: {this.clubName}, atualmente tem {clubFans} torcedores e {clubMoney} em caixa";

            Console.WriteLine(status);
        }

        public void exitGame()
        {
            Console.Clear();
            Console.WriteLine($"Muito obrigado por participar da experiencia PQLFoot, {this.ownerName}");
            Console.ReadKey();
        }







    }
}
