using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Discord_Rich_Presence
{
    public static class HttpClientExtensions
    {
        // .NET framework is retarded, you cant use httpClient.PacthASync because it isnt included in .NET framework, it only works on console apps but this is a work around :D
        // Thanks stackoverflow credit https://stackoverflow.com/questions/26218764/patch-async-requests-with-windows-web-http-httpclient-class
        public static async Task<HttpResponseMessage> PatchAsync(this HttpClient client, Uri requestUri, HttpContent iContent)
        {
            var method = new HttpMethod("PATCH");
            var request = new HttpRequestMessage(method, requestUri)
            {
                Content = iContent
            };

            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                response = await client.SendAsync(request);
            }
            catch (TaskCanceledException e)
            {
                MessageBox.Show("ERROR: " + e.ToString());
            }

            return response;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }

    }
}
