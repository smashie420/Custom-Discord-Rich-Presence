
namespace Custom_Discord_Rich_Presence
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clientID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.details = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Instructions = new System.Windows.Forms.LinkLabel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientID
            // 
            this.clientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clientID.AutoSize = true;
            this.clientID.Location = new System.Drawing.Point(26, 51);
            this.clientID.Name = "clientID";
            this.clientID.Size = new System.Drawing.Size(47, 13);
            this.clientID.TabIndex = 0;
            this.clientID.Text = "Client ID";
            this.clientID.Click += new System.EventHandler(this.url_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(129, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(129, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // details
            // 
            this.details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.details.AutoSize = true;
            this.details.Location = new System.Drawing.Point(26, 77);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(39, 13);
            this.details.TabIndex = 2;
            this.details.Text = "Details";
            this.details.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(129, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 20);
            this.textBox3.TabIndex = 5;
            // 
            // state
            // 
            this.state.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(26, 103);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(32, 13);
            this.state.TabIndex = 4;
            this.state.Text = "State";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(129, 126);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Large Image Name";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(129, 152);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(191, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Large Image Text";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(129, 178);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(191, 20);
            this.textBox6.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Small Image Name";
            // 
            // start
            // 
            this.start.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.start.Location = new System.Drawing.Point(0, 339);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(347, 65);
            this.start.TabIndex = 12;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stop.Location = new System.Drawing.Point(0, 274);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(347, 65);
            this.stop.TabIndex = 13;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(108, 204);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Enable Time Elapsed";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Instructions
            // 
            this.Instructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Instructions.AutoSize = true;
            this.Instructions.Location = new System.Drawing.Point(143, 258);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(61, 13);
            this.Instructions.TabIndex = 15;
            this.Instructions.TabStop = true;
            this.Instructions.Text = "Instructions";
            this.Instructions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Instructions_LinkClicked);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(108, 227);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(73, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Auto Start";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(113, 9);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(91, 13);
            this.labelStatus.TabIndex = 17;
            this.labelStatus.Text = "Status: NO DATA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(347, 404);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.state);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.details);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clientID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(363, 350);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cusotm Discord Status";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel Instructions;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label labelStatus;
    }
}

