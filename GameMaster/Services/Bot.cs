using Discord.WebSocket;
using System.Configuration;
using System.Threading.Tasks;

namespace GameMaster.Services
{
    /// <summary>
    /// A discord bot
    /// </summary>
    /// <remarks> Handles logging in, events such as message reception </remarks>
    public class Bot
    {
        private readonly DiscordSocketClient client;

        public Bot()
        {
            client = new DiscordSocketClient();
        }

        /// <summary>
        /// Set up the bot asynchronously
        /// </summary>
        /// <returns> A task </returns>
        public async Task SetupAsync()
        {
            await client.LoginAsync(Discord.TokenType.Bot, GetAccessToken());
            await client.StartAsync();

            client.MessageReceived += MessageReceived;
        }

        /// <summary>
        /// Event handler for message reception
        /// </summary>
        /// <param name="message"> Message received </param>
        /// <returns> A task </returns>
        private async Task MessageReceived(SocketMessage message)
        {
            if (message.Mentions(client.CurrentUser.Username))
            {
                await message.Channel.SendMessageAsync("hello");
            }
        }

        /// <summary>
        /// Get the access token for this bot
        /// </summary>
        /// <returns> The bot's token </returns>
        private string GetAccessToken() => ConfigurationManager.ConnectionStrings["DiscordBotToken"].ConnectionString;
    }
}