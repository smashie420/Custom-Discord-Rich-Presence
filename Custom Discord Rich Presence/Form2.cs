
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RestSharp;
using RestSharp.Validation;

namespace Custom_Discord_Rich_Presence
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
            api("MzY2MDQxMTk0OTcyODM5OTQx.X7BVnw.PlwLo1I26saMP-eVRsHcTQRgkJU");
        }

       
      
        public class custom_status {
            public string text { get; set; }
            //public string emojiID { get; set; }
        }

        

        public async void api(string token)
        {
            // https://discordapp.com/api/v6/users/@me/settings", headers={"Authorization": token, "Content-Type": "application/json"}, data=status_data
            //string httpContent = @"{""Authorization"": token, ""Content-Type"": ""application/json""}, data=status_data";

            var client = new HttpClient();
            client.PatchASync();


            /* SOMEWHAT WORKING CODE
            var client = new RestClient("https://discordapp.com/api/v6/users/@me/settings");
           
            //client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", token));

            var request = new RestRequest(Method.PATCH) { RequestFormat = DataFormat.Json };
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", token);
            
            request.AddJsonBody(new { op = "replace", path = "/custom_status/", value = "'text':'AWESOMEMMSA'" });

            //{ "op": "replace", "path": "/a/b/c", "value": 42 },
            IRestResponse response = client.Execute(request);
            MessageBox.Show(response.Content);
            */

            /*
            using (var client = new HttpClient())
            {
                

                
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/raw"));
                client.DefaultRequestHeaders.Add("custom_status", "test");

                var Parameters = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("Authorization", "MzY2MDQxMTk0OTcyODM5OTQx.X7BVnw.PlwLo1I26saMP-eVRsHcTQRgkJU"),
                    new KeyValuePair<string, string>("Content-Type", "application/json"),
                };

                var Request = new HttpRequestMessage(HttpMethod.Post, "https://discordapp.com/api/v6/users/@me/settings")
                {
                    Content = new FormUrlEncodedContent(Parameters)
                };

                var Result = client.SendAsync(Request).Result.Content.ReadAsStringAsync();
                string res = await Result;
                MessageBox.Show(res);
                
             }*/



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        bool isEnabled = false;
        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (!isEnabled) { MessageBox.Show("Custom status is already disabled!"); }
            isEnabled = false;
            
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (isEnabled) { return; }
            string userToken = textBox1.Text;
            string text = textBox2.Text;
            api(userToken);
            isEnabled = true;
        }
    }
}
