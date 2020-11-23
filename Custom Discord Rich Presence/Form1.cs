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

                if (!File.Exists("settings.json")) { return; }
                var json = File.ReadAllText("settings.json");

                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);
                DataTable dataSettings = dataSet.Tables["Custom Status"];
                foreach (DataRow row in dataSettings.Rows)
                {
                    textBox1.Text = (string)row["clientID"];
                    textBox2.Text = (string)row["details"];
                    textBox3.Text = (string)row["state"];
                    textBox4.Text = (string)row["largeImageName"];
                    textBox5.Text = (string)row["largeimageText"];
                    textBox6.Text = (string)row["smallimageName"];
                    checkBox2.Checked = (bool)Convert.ToBoolean(row["autoStartChk"]);
                }

                /*
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

                /*
                textBox1.Text = details["clientID"];
                textBox2.Text = details["details"];
                textBox3.Text = details["state"];
                textBox4.Text = details["largeImageName"];
                textBox5.Text = details["largeimageText"];
                textBox6.Text = details["smallimageName"];
                checkBox2.Checked = Convert.ToBoolean(details["autoStartChk"]);
                labelStatus.Text = "Status: STOPPED";
                */
            }
            if (checkBox2.Checked)
            {
                var json = File.ReadAllText("settings.json");

                DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);
                DataTable dataSettings = dataSet.Tables["Custom Status"];
                foreach (DataRow row in dataSettings.Rows)
                {
                    textBox1.Text = (string)row["clientID"];
                    textBox2.Text = (string)row["details"];
                    textBox3.Text = (string)row["state"];
                    textBox4.Text = (string)row["largeImageName"];
                    textBox5.Text = (string)row["largeimageText"];
                    textBox6.Text = (string)row["smallimageName"];
                    checkBox2.Checked = (bool)Convert.ToBoolean(row["autoStartChk"]);
                }



                client = new DiscordRpcClient(textBox1.Text.ToString());
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
                    Details = textBox2.Text.ToString(),
                    State = textBox3.Text.ToString(),
                    Assets = new Assets()
                    {
                        LargeImageKey = textBox4.Text.ToString(),
                        LargeImageText = textBox5.Text.ToString(),
                        SmallImageKey = textBox6.Text.ToString()
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
            if (isEnabled) { return; }
            //string jsonstuff = "{\"Custom Status\": [{\"clientID\": \"{0}\",\"details\": \"{1}\",\"state\": \"{2}\",\"largeImageName\": \"{3}\",\"largeimageText\": \"{4}\",\"smallimageName\": \"{5}\",\"autoStartChk\": \"{6}\"}],\"Animated Status\":[{\"userID\": \"\",\"animation\": \"\",\"delay\": \"\"}]}";

            //MessageBox.Show(String.Format("{\"Custom Status\": [{\"clientID\": \"{0}\",\"details\": \"{1}\",\"state\": \"{2}\",\"largeImageName\": \"{3}\",\"largeimageText\": \"{4}\",\"smallimageName\": \"{5}\",\"autoStartChk\": \"{6}\"}],\"Animated Status\":[{\"userID\": \"\",\"animation\": \"\",\"delay\": \"\"}]}", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, checkBox2.Checked.ToString()));
            
            using (StreamWriter writer = File.CreateText("settings.json"))
            {
                writer.WriteLine(String.Format("{{ \"Custom Status\": [ {{\"clientID\": \"{0}\",\"details\": \"{1}\",\"state\": \"{2}\",\"largeImageName\": \"{3}\",\"largeimageText\": \"{4}\",\"smallimageName\": \"{5}\",\"autoStartChk\": \"{6}\"}}],\"Animated Status\":[{{\"userID\": \"\",\"animation\": \"\",\"delay\": \"\"}}]}}", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, checkBox2.Checked.ToString()));
            }

            var json = File.ReadAllText("settings.json");

            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);
            DataTable dataSettings = dataSet.Tables["Custom Status"];
            foreach (DataRow row in dataSettings.Rows)
            {
                textBox1.Text = (string)row["clientID"];
                textBox2.Text = (string)row["details"];
                textBox3.Text = (string)row["state"];
                textBox4.Text = (string)row["largeImageName"];
                textBox5.Text = (string)row["largeimageText"];
                textBox6.Text = (string)row["smallimageName"];
                checkBox2.Checked = (bool)Convert.ToBoolean(row["autoStartChk"]);
            }

            client = new DiscordRpcClient(textBox1.Text);


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
                Details = textBox2.Text,
                State = textBox3.Text,
                Assets = new Assets()
                {
                    LargeImageKey = textBox4.Text,
                    LargeImageText = textBox5.Text,
                    SmallImageKey = textBox6.Text
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
            isEnabled = false;
            this.Hide();
            Form2 form2 = new Form2();
            // This is for when form2 is closed it also closes form1
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
        
    }
   
}
