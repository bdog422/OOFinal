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
        private Quest quests;
        public int questCounter;
        public int placement = 0;
        public Form1()
        {
            InitializeComponent();
            player = new Player(100, 20, 10);
            quests = new Quest();

            GetNameInput();

            textBox1.Text = "Hello " + player.Name + ". A long path lays before you. Are you up for the task?" + Environment.NewLine +
                "You walk into town and a strange man stands before you. He declares his name is Papa Long Johns." + Environment.NewLine +
                "He challenges you to a duel. If you don't accept, your honor will be ruined and he will probably kill you anyways." + Environment.NewLine +
                "You are a poor homeless person without any gear or means to defeand yourself. Do you fight him now, or ask for a couple of days to prepare?";



            
                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("Fight him right now!");
                comboBox1.Items.Add("Ask for a couple of days.");

                

            
        }

        public void GameStart()
        {
            placement = 1;
            if( comboBox1.SelectedIndex == 0 && questCounter == 1)
            {
                textBox1.Text = "'You look like you need a drink', says the dwarf across the bar. " + Environment.NewLine +
                    "Do you go drink with him?";
                questCounter = 10;
                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("Drink with him");
                comboBox1.Items.Add("Refuse to drink");
            }
            else if(questCounter + comboBox1.SelectedIndex == 10)
            {
                textBox1.Text = "'I'll tell you what. If you can out drink me, I can give you a helmet to help in the fight against Papa Long Johns'" + Environment.NewLine +
                    "Do you take him up on this challenge?";
                questCounter = 12;
                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();

                comboBox1.Items.Add("Outdrink this nerd");
                comboBox1.Items.Add("You just want to relax");
            }
            else if(questCounter + comboBox1.SelectedIndex == 12)
            {
                textBox1.Text = "'First one to pass out or is unable to drink loses. We will go drink for drink with the finest of dwarven ale.'" + Environment.NewLine +
                    "The first drink is difficult to swallow since you have little to no experience with dwarven ale." + Environment.NewLine +
                    "Do you take another?";
                questCounter = 14;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();

                comboBox1.Items.Add("Keep the drinks coming!");
                comboBox1.Items.Add("Call it quits.");
            }
            else if(questCounter + comboBox1.SelectedIndex == 14)
            {
                textBox1.Text = "The dwarf stares at you in surprise." + Environment.NewLine + "'Nobody has ever managed" +
                    "to get past the first drink. I'm getting excited!'" + Environment.NewLine + "'Listen kid, if you survive this" +
                    "next drink I'll let you call me Guile'. The world rotates on two seperate axis's." + Environment.NewLine +
                    "Do you take another drink?";
                questCounter = 16;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();

                comboBox1.Items.Add("Mama didn't raise no quitter!");
                comboBox1.Items.Add("You prefer to live");
            }
            else if(questCounter + comboBox1.SelectedIndex == 16)
            {
                textBox1.Text = "You guzzle down the next glass and the room starts to rumble. Whatever is in this" +
                    "ale is no joke. You dread what comes tomorrow." + Environment.NewLine + "You already feel" +
                    "the hangover as you slowly sip the ale. Your taste buds have been destroyed and it" +
                    "has become second nature to immediately swallow any drink brought to you." + Environment.NewLine +
                    "Eventually the Dwarf could no longer bring the glass to his lips and you win!" + Environment.NewLine +
                    "You win a helmet for the coming fight and the pride of out drinking a dwarf!" + Environment.NewLine + "( Press continue to continue )";

                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if(questCounter + comboBox1.SelectedIndex == 15)
            {
                textBox1.Text = "Luckily for you, the Dwarf already fell asleep with half of his drink left." + Environment.NewLine +
                    "You win the contest and gain a helmet for the upcoming battle!" + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if(questCounter + comboBox1.SelectedIndex == 13)
            {
                textBox1.Text = "'Alright buddy, I'll just share a drink with ya.'" + Environment.NewLine +
                    "You have a nice drink with the dwarf and head out on the next adventure." + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if(questCounter + comboBox1.SelectedIndex == 11)
            {
                textBox1.Text = "'I can't tell you how to live your life, but taking a break every once in a while" +
                    "can be a good thing in the long run." + Environment.NewLine +
                    "Good luck against Papa Long Johns."
                    + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }

            else
            {
                textBox1.Text = "'Fine, you can have a week at most to gather your pitiful supplies and pride. " + Environment.NewLine +
                    " Well Kiddo, you better get some equipment so you don't die to Papa Long Johns. " + Environment.NewLine +
                    "Maybe go help around the community for supplies?";

                questCounter = 1;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. A drinking contest with a dwarf");
                comboBox1.Items.Add("2. The great bet money heist");
                comboBox1.Items.Add("3. The runaway");
                comboBox1.Items.Add("4. The magical artifact");
                comboBox1.Items.Add("5. The Magistrate issue");
                comboBox1.Items.Add("Go fight Papa Long Johns!");
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
            if(comboBox1.SelectedIndex == 0  && placement == 0)
            {
                // Fight time
            }

            else if(comboBox1.SelectedIndex == 1 && placement == 0)
            {
                GameStart();
            }
            else if(placement >= 1)
            {
                GameStart();
            }
            
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
