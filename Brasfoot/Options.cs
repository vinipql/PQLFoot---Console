using System;
using System.Collections.Generic;
using System.Text;

namespace Brasfoot
{
    public class Options
    {
        //instanciamento de objetos
        Squad s1 = new Squad();
        static Clubs c1 = new Clubs();
        public Leagues l1 = new Leagues();
        Calendar cal = new Calendar();


        public void firtMenu()
        {
            Console.WriteLine($"Bem vindo ao PQLFoot!{Environment.NewLine}" +
                $"Por favor, digite o seu nome: {Environment.NewLine}");
            c1.setOwnerName(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Olá, {c1.getOwnerName()}! Por gentileza, digite um nome para o seu clube: {Environment.NewLine}");
            c1.setClubName(Console.ReadLine());
        }

        public static string passOwnerName()
        {
            string passOwner = c1.getClubName();
            int size = 17;

            while(passOwner.Length < 17)
            {
                passOwner += "-";
            }


            return passOwner;
        }


        public bool MainMenu()
        {


                List<int> optionNumber = new List<int> { 1, 2, 3, 4 };

                Console.Clear();
                Console.WriteLine($"Esse é o menu do Brasfoot, {c1.getOwnerName()}{Environment.NewLine}" +
                    $"Escolha uma das opções abaixo para prosseguir{Environment.NewLine}" +
                    $"1 - Ver o elenco atual{Environment.NewLine}" +
                    $"2 - Verificar a tabela do campeonato nacional{Environment.NewLine}" +
                    $"3 - Verificar calendario dos próximos jogos{Environment.NewLine}" +
                    $"4 - Acessar o mercado de transferencias{Environment.NewLine}" +
                    $"5 - Ver status atual do clube{Environment.NewLine}" +
                    $"6 - Sair do Jogo");



                switch (Console.ReadLine())
                {
                    case "1":
                    s1.defineSquad();
                    Console.ReadKey();
                    return true;
                    case "2":
                    l1.orgazineTable();
                    Console.ReadKey();
                        return true;
                    case "3":
                    cal.StartCalendar();
                    cal.setCalendar(c1.getClubName(), l1.ControyChampionship());
                    Console.ReadKey();
                         return true;
                    case "4":
                        return true;
                    case "5":
                    c1.showStatus();
                    Console.ReadKey();
                        return true;
                    case "6":
                    c1.exitGame();
                        return false;
                    default:
                        return true;
                }
              

        }
    }
}
