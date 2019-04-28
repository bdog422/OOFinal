using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace OOFinal
{
    public partial class Form1 : Form
    {
        private Player player;
        private Quest quest;
        public int placement = 0;
        public Form1()
        {
            InitializeComponent();
            player = new Player(100, 20, 10);

            GetNameInput();

            textBox1.Text = "Hello " + player.Name + ". A long path lays before you. Are you up for the task?" + Environment.NewLine +
                "You walk into town and a strange man stands before you. He declares his name is Papa Long Johns." + Environment.NewLine +
                "He challenges you to a duel. If you don't accept, your honor will be ruined and he will probably kill you anyways." + Environment.NewLine +
                "You are a poor homeless person without any gear or means to defeand yourself. Do you fight him now, or ask for a couple of days to prepare?";



            if (comboBox1.SelectedIndex == 0 && placement == 0)
            {
                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("Fight him right now!");
                comboBox1.Items.Add("Ask for a couple of days.");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        public void GetNameInput()
        {
            InputForm NameInput = new InputForm();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (NameInput.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                this.player.Name = NameInput.PlayerNameInputBox.Text;
            }
            NameInput.Dispose();
        }
    }
}
