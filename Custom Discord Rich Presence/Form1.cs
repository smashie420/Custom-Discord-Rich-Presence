using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
using Newtonsoft.Json;


namespace Custom_Discord_Rich_Presence
{
    public partial class Form1 : Form
    {
        public bool isEnabled { get; set; }
        public DiscordRpcClient client;

        public class data
        {
            public string clientID { get; set; }
            public string details { get; set; }
            public string state { get; set; }
            public string largeImageName { get; set; }
            public string largeimageText { get; set; }
            public string smallimageName { get; set; }
            public bool autoStartChk { get; set; }
        }
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
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


                textBox1.Text = details["clientID"];
                textBox2.Text = details["details"];
                textBox3.Text = details["state"];
                textBox4.Text = details["largeImageName"];
                textBox5.Text = details["largeimageText"];
                textBox6.Text = details["smallimageName"];
                checkBox2.Checked = Convert.ToBoolean(details["autoStartChk"]);
                labelStatus.Text = "Status: STOPPED";

            }
            if (checkBox2.Checked)
            {
                string json = File.ReadAllText("settings.json");
                Dictionary<string, string> details = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                textBox1.Text = details["clientID"];
                textBox2.Text = details["details"];
                textBox3.Text = details["state"];
                textBox4.Text = details["largeImageName"];
                textBox5.Text = details["largeimageText"];
                textBox6.Text = details["smallimageName"];
                checkBox2.Checked = Convert.ToBoolean(details["autoStartChk"]);



                client = new DiscordRpcClient(details["clientID"]);
                isEnabled = true;
                labelStatus.Text = "Status: RUNNING";
                if (String.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Client ID is empty!");
                    return;
                }
                client = new DiscordRpcClient(textBox1.Text);
                // You get a client id by creating an app from https://discord.com/developers/applications/


                //Connect to the RPC
                client.Initialize();

                //Set the rich presence
                //Call this as many times as you want and anywhere in your code.
                client.SetPresence(new RichPresence()
                {
                    Details = details["details"],
                    State = details["state"],
                    Assets = new Assets()
                    {
                        LargeImageKey = details["largeImageName"],
                        LargeImageText = details["largeimageText"],
                        SmallImageKey = details["smallimageName"]
                    }
                });
                if (checkBox1.Checked)
                {
                    client.UpdateStartTime();
                }
                

            }
            
           
        }

        private void url_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
        
        private void start_Click(object sender, EventArgs e)
        {
            data tojson = new data
            {
                clientID = textBox1.Text,
                details = textBox2.Text,
                state = textBox3.Text,
                largeImageName = textBox4.Text,
                largeimageText = textBox5.Text,
                smallimageName = textBox6.Text,
                autoStartChk = checkBox2.Checked

            };
            string jsontoWrite = JsonConvert.SerializeObject(tojson, Formatting.Indented);

            using (StreamWriter writer = File.CreateText("settings.json"))
            {
                writer.WriteLine(jsontoWrite);
            }


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


            textBox1.Text = details["clientID"];
            textBox2.Text = details["details"];
            textBox3.Text = details["state"];
            textBox4.Text = details["largeImageName"];
            textBox5.Text = details["largeimageText"];
            textBox6.Text = details["smallimageName"];
            checkBox2.Checked = Convert.ToBoolean(details["autoStartChk"]);
            


            client = new DiscordRpcClient(details["clientID"]);


            isEnabled = true;
            labelStatus.Text = "Status: RUNNING";
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Client ID is empty!");
                return;
            }
            client = new DiscordRpcClient(textBox1.Text);
            // You get a client id by creating an app from https://discord.com/developers/applications/


            //Connect to the RPC
            client.Initialize();

            //Set the rich presence
            //Call this as many times as you want and anywhere in your code.
            client.SetPresence(new RichPresence()
            {
                Details = details["details"],
                State = details["state"],
                Assets = new Assets()
                {
                    LargeImageKey = details["largeImageName"],
                    LargeImageText = details["largeimageText"],
                    SmallImageKey = details["smallimageName"]
                }
            });
            if (checkBox1.Checked)
            {
                client.UpdateStartTime();
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            
            if(isEnabled) {
                client.Deinitialize();
            }
            else
            {
                MessageBox.Show("Custom status is already disabled!");
            }
            labelStatus.Text = "Status: STOPPED";
            isEnabled = false;

        }

        private void Instructions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/smashie420/Custom-Discord-Rich-Presence/blob/master/README.md");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            // This is for when form2 is closed it also closes form1
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
        
    }
   
}
