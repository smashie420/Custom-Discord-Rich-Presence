
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Validation;


namespace Custom_Discord_Rich_Presence
{
    

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public class data
        {
            public string userID { get; set; }
            public string animation { get; set; }
            public string delay { get; set; }
            
        }
        public static string loop { get; set; }
       
        public async void api(string token, string text)
        {
            int scrollLength = 22;
            while (isEnabled)
            {
                
                   
                // For animated txt
                
                loop = "";
                foreach (char n in text)
                {
                      
                    if (comboBox1.Text == "Scrolling Text")
                    {
                        if (loop.Length > scrollLength)
                        {
                            loop = loop.Substring(1);
                        }
                    } 
                    if (comboBox1.Text == "Clearing Text")
                    {
                        if (loop.Length > scrollLength)
                        {
                            loop = "";
                        }
                    }
                    loop += n;
                    try
                    {
                        string url = "https://discordapp.com/api/v6/users/@me/settings";
                        var client = new HttpClient();
                        //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                        client.DefaultRequestHeaders.Add("Authorization", token);
                        string jsontxt = String.Format("{{ \"custom_status\":{{ \"text\": \"{0}\" }} }}", loop);


                        var responseMessage = await HttpClientExtensions.PatchAsync(client, new Uri(url), new StringContent(jsontxt, Encoding.UTF8, "application/json"));

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        break;
                    }
                    if(comboBox2.Text == "200ms") { Thread.Sleep(200); }
                    if (comboBox2.Text == "500ms") { Thread.Sleep(500); }
                    if (comboBox2.Text == "1000ms") { Thread.Sleep(1000); }
                    if (comboBox2.Text == "2000ms") { Thread.Sleep(2000); }
                    if (comboBox2.Text == "5000ms") { Thread.Sleep(5000); }
                    Thread.Sleep(200);
                }
                text = " " + text + " ";
                
                /*
                loop = "";
                int scrollLength = 22;
                foreach(char n in text)
                {
                    if(loop.Length > scrollLength)
                    {
                        loop = " ";
                    }
                    loop += n;
                    MessageBox.Show(loop);
                }*/




                // https://discordapp.com/api/v6/users/@me/settings", headers={"Authorization": token, "Content-Type": "application/json"}, data=status_data


            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (File.Exists("settings.json"))
            {
                string json = File.ReadAllText("settings.json");
                Dictionary<string, string> details = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                /*
                var clientID1 = details["clientID"]);
                var details1 = details["details"]);
                var state1 = details["state"]);
                var largeImageName1 = details["largeImageName"]);
                var largeimageText1 = details["largeimageText"]);
                var smallimageName1 = details["smallimageName"]);*/
                // /account/login.aspx


                textBox1.Text = details["userID"];
                comboBox1.Text = details["animation"];
                comboBox2.Text = details["delay"];
                

            }
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
            data tojson = new data
            {
                userID = textBox1.Text,
                animation = comboBox1.Text,
                delay = comboBox2.Text,
            };
            string jsontoWrite = JsonConvert.SerializeObject(tojson, Formatting.Indented);

            using (StreamWriter writer = File.AppendText("settings.json"))
            {
                writer.WriteLine(jsontoWrite);
            }

            string userToken = textBox1.Text;
            string text = textBox2.Text;
            isEnabled = true;
            api(userToken, text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            // This is for when form2 is closed it also closes form1
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
