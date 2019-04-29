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
            // end of quest 1
            else if(questCounter + comboBox1.SelectedIndex == 2)
            {
                textBox1.Text = "You walk into the local fight club and see a mountain of gold sitting on the table." + Environment.NewLine +
                    "It seems like only the bartender can see you..." + Environment.NewLine +
                    "What do you do?";
                questCounter = 20;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. Get the bartender to look away and steal the gold.");
                comboBox1.Items.Add("2. Enter the fight club to win the gold");
                comboBox1.Items.Add("3. Take the gold right in front of the bartender.");
                comboBox1.Items.Add("4. Walk out of the establisment.");

            }
            
            else if(questCounter + comboBox1.SelectedIndex == 20)
            {
                textBox1.Text = "You scream 'LOOK AT THAT GNOME' and point at an empty chair. The bartender starts walking" +
                    "where you pointed at in confusion." + Environment.NewLine + "You put as much gold into your pack as" +
                    "possible and also grab an ornate dagger." + Environment.NewLine + "What is your next plan?";

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();
                questCounter = 24;

                comboBox1.Items.Add("1. Leave the club with your 'Winnings'.");
                comboBox1.Items.Add("2. Stash your loot somewhere outside and come back.");
                comboBox1.Items.Add("3. Stay right where you are.");

            }
            else if(questCounter + comboBox1.SelectedIndex == 25)
            {
                textBox1.Text = "You sneak outside and kick some dirt over your pack. You rush back inside like nothing " +
                    "happens and start to observe the fight." + Environment.NewLine + "Soon you hear the bartender screaming" +
                    "'Someone snatched the bet money!'" + Environment.NewLine + "Everyone rushes inside to see the commotion." +
                    " The local guards come inside to search people to see who stole the money. Good thing you stashed the " +
                    "loot or you would have been caught." + Environment.NewLine + "All of a sudden, 3 Gnomes jump out of a trench" +
                    "coat and start running away!" + Environment.NewLine + "What do you do?";

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();
                questCounter = 27;

                comboBox1.Items.Add("1. Go after the Gnomes.");
                comboBox1.Items.Add("2. This is not your problem.");

            }
            else if(questCounter + comboBox1.SelectedIndex == 26)
            {
                textBox1.Text = "The bartender stares at you, then at the missing pile of gold." + Environment.NewLine + "'Listen" +
                    " kid, you can put all the bet winnings back and I'll let you go.'" + Environment.NewLine +
                    "What do you do?";

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();
                questCounter = 29;

                comboBox1.Items.Add("1. Listen to the nice man.");
                comboBox1.Items.Add("2. Run as fast as you can.");
                comboBox1.Items.Add("3. Put everything back but the dagger");

            }
            else if(questCounter + comboBox1.SelectedIndex == 31)
            {
                textBox1.Text = "'Good job kid. I know how tough it can be on the streets. Don't worry, I won't tell anyone" +
                    "what you tried to do. Get out of here before it becomes and issue again.'" + Environment.NewLine + 
                    "You escape the club with the dagger. You can now defend yourself from Papa Long Johns!" + Environment.NewLine + "(Press continue to continue)";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 30)
            {
                textBox1.Text = "You try running but the bartender throws a mug at the back of your head." + Environment.NewLine +
                    "'This could have ended nicely but you had to play dumb.'" + Environment.NewLine + "He snatches everything" +
                    "out of your bag since you decided to be a stupid theif." + Environment.NewLine + "(Press continue to continue)";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if(questCounter + comboBox1.SelectedIndex == 29)
            {
                textBox1.Text = "You put everything back on the counter including the dagger." + Environment.NewLine +
                    "'You did a good thing kiddo. I know the temptation is hard to fight sometimes.'" + Environment.NewLine +
                    "You lost everything you worked for. Have fun not having a dagger to use dummy." + Environment.NewLine + "(Press continue to continue)";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if(questCounter + comboBox1.SelectedIndex == 27)
            {
                textBox1.Text = "You are the first one to start sprinting after the gnomes. Since you acted quick on your feet" +
                    "nobody suspected you to be the thief all along." + Environment.NewLine + "You escape with the gold and dagger." +
                    "You now have a weapon to fight Papa Long Johns with!" + Environment.NewLine + "(Press continue to continue)";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 28)
            {
                textBox1.Text = "You leave an pick up your pack. Unfortunately someone stole some of the gold but left the dagger." +
                    Environment.NewLine + "At least you have a weapon now!" + Environment.NewLine + "(Press continue to continue)";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }

            else if (questCounter + comboBox1.SelectedIndex == 21)
            {
                textBox1.Text = "You decide to enter the fight club. Good thing you were raised on the streets" +
                               "and know how to fight." + Environment.NewLine + "Do you want to fight to win, or fight honorably?";

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();
                questCounter = 32;

                comboBox1.Items.Add("1. Fight honorably?");
                comboBox1.Items.Add("2. Fight dirty?");
                
            }
            else if (questCounter + comboBox1.SelectedIndex == 32)
            {
                textBox1.Text = "You decide that the best way to fight these people is on equal footing. You gain nothing" +
                    "from the exchange of blows that follows." + Environment.NewLine + "Somehow you win, but took a major beating " +
                    "while doing so. Most of the people watching you are worried about your health for the coming days." + Environment.NewLine +
                    "at least you got a sick new dagger to fight Papa Long Johns with!" + Environment.NewLine + "(Press continue to continue)";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if(questCounter + comboBox1.SelectedIndex == 33)
            {
                textBox1.Text = "Fighting honorably is a fool's errand that gets people killed more than it saves your pride." + Environment.NewLine +
                    "There is no special reward for being a good person in a fist fight. You dip, duck, and doge each fist and throw your own." + Environment.NewLine +
                    "Somehow you defeat the last person and go home with all the winnings!" + Environment.NewLine +
                    "You now have a dagger to fight Papa Long Johns with!" + Environment.NewLine + "(Press continue to continue)";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if(questCounter + comboBox1.SelectedIndex == 22)
            {
                textBox1.Text = "'Kid, I'll give you one chance to put that gold back before I get the entire club in here to take it " +
                    "back by force.'" + Environment.NewLine + "He saw you pocket the gold. What do you do now?";

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();
                questCounter = 34;

                comboBox1.Items.Add("1. Call him a fat fairy and run away.");
                comboBox1.Items.Add("2. Put the gold back to avoid possible death");
            }
            else if(questCounter + comboBox1.SelectedIndex == 34)
            {
                textBox1.Text = "As you shout your insult and run you crash into the crowd that was outside a moment ago." + Environment.NewLine +
                    "They don't seem happy that you tried to run off with the bet money..." + Environment.NewLine +
                    "Somehow, agaisnt all odds you survived the entire crowd gave you." + Environment.NewLine +
                    "After facing them, you could probably take on Papa Long Johns wearing nothing but your shorts." + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if(questCounter + comboBox1.SelectedIndex == 35)
            {
                textBox1.Text = "You made the right call as the entire crowd outside comes back when you set the gold down." + Environment.NewLine +
                    "Looks like you get to live another day!" + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if(questCounter + comboBox1.SelectedIndex == 23)
            {
                textBox1.Text = "Stealing and violence will not solve your issues." + Environment.NewLine +
                    "You decide that tomorrow is another day to make money." + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }


            else if(questCounter + comboBox1.SelectedIndex == 24)
            {
                textBox1.Text = "Momma didn't raise a sucker. You take what you earned and leave the club like nothing happened." + Environment.NewLine +
                    "The gold is a nice bonus but the real prize is the dagger. You now have a weapon to fight Papa Long Johns with."
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
