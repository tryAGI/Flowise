#nullable enable

namespace Flowise
{
    public partial interface IPingClient
    {
        /// <summary>
        /// Ping the server<br/>
        /// Ping the server to check if it is running
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Flowise.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PingServerAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}