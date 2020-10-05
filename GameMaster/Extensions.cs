using Discord.WebSocket;
using System.Linq;

namespace GameMaster
{
    /// <summary>
    /// Extension Methods
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Determines if a message mentions a given username
        /// </summary>
        /// <param name="message"> Message to search </param>
        /// <param name="username"> Username to search for </param>
        /// <returns> True if the given username is mentioned </returns>
        public static bool Mentions(this SocketMessage message, string username)
            => message.MentionedUsers.Any(x => x.Username == username);
    }
}