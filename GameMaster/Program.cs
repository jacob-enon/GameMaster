using GameMaster.Services;
using System.Threading.Tasks;

namespace GameMaster
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var bot = new Bot();
            await bot.SetupAsync();

            await Task.Delay(-1);
        }
    }
}