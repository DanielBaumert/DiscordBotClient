using Se7en.Network;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HttpClient = System.Net.Http.HttpClient;

#nullable enable

namespace DiscordLib {
    public class Discord {
        private static Regex _parameterRegex = new Regex(Const.PARAMETER_PATTER);
        private const string _userAgend =
            "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/73.0.3683.103 Mobile Safari/537.36";

        private string _token;
        private string _gateway;
        private CookieContainer _container;

        private Discord() {

        }

        public static Discord? Connect(string email, string password) {
            Discord discord = new Discord {
                _container = new CookieContainer()
            };

            string query = string.Format(Const.LOGIN_QUERY, email, password);
            string result = discord.SendRequest(Const.LOGIN_URL, WebRequestType.POST, query);

            if (string.IsNullOrEmpty(result)) {
                return null;
            }

            if (result.Contains("token")) {
                discord._token = _parameterRegex.Match(result.Split(':')[1]).Groups[1].Value;
            }
            discord._gateway = discord.GetGateWayAsync();


            return discord;
        }

        private void OpenWebSocked() {


        }

        public void GetChannels() {
            TcpIpClient client = new TcpIpClient();
            client.ResiveMessage += Client_ResiveMessage;
            client.Connect(_gateway, Const.WEB_SOCKET_PORT);
            
            string bla = SendRequest(Const.CHANNEL_URL, WebRequestType.GET);
        }

        private void Client_ResiveMessage(TcpIpClient arg1, string arg2) {

        }

        public void SwitchName(string serverID, string name) {
            string url = string.Format(Const.NAME_SWITCH_URL, serverID);
            string query = string.Format(Const.NAME_SWITCH_QUERY, name);

            SendRequest(url, WebRequestType.POST, query, new[] { ("authorization", _token) });
        }

        public void SendMessage(string channelID, string content) {
            string url = string.Format(Const.SEND_MESSAGE_URL, channelID);
            string query = string.Format(Const.SEND_MESSAGE_QUERY, content);

            SendRequest(url, WebRequestType.POST, query, new[] { ("authorization", _token) });
        }

        private string GetGateWayAsync() {
            string result = SendRequest(Const.GATEWAY_URL);
            if (result.Contains("url"))
                return _parameterRegex.Match(result).Groups[1].Value;
            return string.Empty; //TODO 
        }

        private string SendRequest(string url,
                                   WebRequestType method = WebRequestType.GET,
                                   string parameter = "",
                                   (string key, string value)[] requestHeaderOption = null,
                                   string contentType = "application/json"
        ) {
            using HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.CookieContainer = _container;
            clientHandler.ClientCertificateOptions = ClientCertificateOption.Automatic;

            using HttpClient client = new HttpClient(clientHandler);


            if (requestHeaderOption != null)
                foreach ((string key, string value) in requestHeaderOption)
                    client.DefaultRequestHeaders.Add(key, value);

            HttpMethod methodType = method switch
            {
                WebRequestType.GET => HttpMethod.Get,
                WebRequestType.POST => HttpMethod.Post,
                WebRequestType.PUT => HttpMethod.Put,
                WebRequestType.DELETE => HttpMethod.Delete,
                WebRequestType.HEAD => HttpMethod.Head,
                _ => throw new System.Exception()
            };

            HttpRequestMessage request = new HttpRequestMessage(methodType, "relativeAddress");
            request.Content = new StringContent(parameter, Encoding.UTF8, contentType);


            try {
                return client.SendAsync(request).Result.Content.ReadAsStringAsync().Result;
            } catch {
                return string.Empty;
            }
        }

        private static class Const {
            internal const int WEB_SOCKET_PORT = 9222;

            internal const string GATEWAY_URL = "https://discordapp.com/api/v6/gateway";
            internal const string LOGIN_URL = "https://discordapp.com/api/v6/auth/login";
            internal const string NAME_SWITCH_URL = "https://discordapp.com/api/v6/guilds/{0}/member/@me/nick";
            internal const string SEND_MESSAGE_URL = "https://discordapp.com/api/v6/channels/{0}/messages";
            internal const string CHANNEL_URL = "https://discordapp.com/api/v6/channels/";

            internal const string PARAMETER_PATTER = @"""([^""]*)""";
            internal const string LOGIN_QUERY =
                @"{{""email"":""{0}"",""password"":""{1}"",""undelete"":false,""captcha_key"":null,""login_source"":null,""gift_code_sku_id"":null}}";

            internal const string NAME_SWITCH_QUERY = @"{{""nick"": ""{0}""}}";
            internal const string SEND_MESSAGE_QUERY = @"{{""content"":""{0}"",""tts"":false}}";
        }
    }
}