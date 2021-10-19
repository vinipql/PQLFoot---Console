using Newtonsoft.Json;
using Refit;
using System;
using System.Threading.Tasks;

namespace Brasfoot
{
    class Program
    {

        static async Task Main(string[] args)
        {
            
            try
            {
                var listaNomes = RestService.For<IReceiveNames>("https://api.fungenerators.com");

                var names = await listaNomes.GetAdressAsync();

                Squad[] nomes = JsonConvert.DeserializeObject<Squad[]>(names.Name);

                Console.WriteLine(nomes);


            } catch(Exception e)
            {
            }
            
            
            
            
            
            
            Options op1 = new Options();
            op1.firtMenu();
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = op1.MainMenu();
            }
        }
    }
}
