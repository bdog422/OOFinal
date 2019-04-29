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
            if (comboBox1.SelectedIndex == 0 && questCounter == 1)
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
            else if (questCounter + comboBox1.SelectedIndex == 10)
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
            else if (questCounter + comboBox1.SelectedIndex == 12)
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
            else if (questCounter + comboBox1.SelectedIndex == 14)
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
            else if (questCounter + comboBox1.SelectedIndex == 16)
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
            else if (questCounter + comboBox1.SelectedIndex == 15)
            {
                textBox1.Text = "Luckily for you, the Dwarf already fell asleep with half of his drink left." + Environment.NewLine +
                    "You win the contest and gain a helmet for the upcoming battle!" + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 13)
            {
                textBox1.Text = "'Alright buddy, I'll just share a drink with ya.'" + Environment.NewLine +
                    "You have a nice drink with the dwarf and head out on the next adventure." + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 11)
            {
                textBox1.Text = "'I can't tell you how to live your life, but taking a break every once in a while" +
                    "can be a good thing in the long run." + Environment.NewLine +
                    "Good luck against Papa Long Johns."
                    + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            // end of quest 1
            else if (questCounter + comboBox1.SelectedIndex == 2)
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

            else if (questCounter + comboBox1.SelectedIndex == 20)
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
            else if (questCounter + comboBox1.SelectedIndex == 25)
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
            else if (questCounter + comboBox1.SelectedIndex == 26)
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
            else if (questCounter + comboBox1.SelectedIndex == 31)
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
            else if (questCounter + comboBox1.SelectedIndex == 29)
            {
                textBox1.Text = "You put everything back on the counter including the dagger." + Environment.NewLine +
                    "'You did a good thing kiddo. I know the temptation is hard to fight sometimes.'" + Environment.NewLine +
                    "You lost everything you worked for. Have fun not having a dagger to use dummy." + Environment.NewLine + "(Press continue to continue)";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 27)
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
            else if (questCounter + comboBox1.SelectedIndex == 33)
            {
                textBox1.Text = "Fighting honorably is a fool's errand that gets people killed more than it saves your pride." + Environment.NewLine +
                    "There is no special reward for being a good person in a fist fight. You dip, duck, and doge each fist and throw your own." + Environment.NewLine +
                    "Somehow you defeat the last person and go home with all the winnings!" + Environment.NewLine +
                    "You now have a dagger to fight Papa Long Johns with!" + Environment.NewLine + "(Press continue to continue)";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 22)
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
            else if (questCounter + comboBox1.SelectedIndex == 34)
            {
                textBox1.Text = "As you shout your insult and run you crash into the crowd that was outside a moment ago." + Environment.NewLine +
                    "They don't seem happy that you tried to run off with the bet money..." + Environment.NewLine +
                    "Somehow, agaisnt all odds you survived the entire crowd gave you." + Environment.NewLine +
                    "After facing them, you could probably take on Papa Long Johns wearing nothing but your shorts." + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 35)
            {
                textBox1.Text = "You made the right call as the entire crowd outside comes back when you set the gold down." + Environment.NewLine +
                    "Looks like you get to live another day!" + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 23)
            {
                textBox1.Text = "Stealing and violence will not solve your issues." + Environment.NewLine +
                    "You decide that tomorrow is another day to make money." + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }


            else if (questCounter + comboBox1.SelectedIndex == 24)
            {
                textBox1.Text = "Momma didn't raise a sucker. You take what you earned and leave the club like nothing happened." + Environment.NewLine +
                    "The gold is a nice bonus but the real prize is the dagger. You now have a weapon to fight Papa Long Johns with."
                    + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }


            ///////////////////// End quest 2

            else if (questCounter + comboBox1.SelectedIndex == 3)
            {
                textBox1.Text = "Oh no, it seems that an elderly lady is searching for her lost cat." + Environment.NewLine +
                    "Do you want to help her?";

                questCounter = 40;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. As a good citizen, you must help this lady!");
                comboBox1.Items.Add("2. Uh.... no. You have much larger problems to handle.");
            }
            else if (questCounter + comboBox1.SelectedIndex == 40)
            {
                textBox1.Text = "What is the best course of action?";

                questCounter = 42;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. Sprint off in another direction.");
                comboBox1.Items.Add("2. Ask the lady where she last saw her cat");

            }
            else if (questCounter + comboBox1.SelectedIndex == 43)
            {
                textBox1.Text = "'I last saw Mr. Mittens around the local pub. I hope he is doing alright!'" + Environment.NewLine +
                    "After giving you one sentence of information, the lady faints for some story related reason." + Environment.NewLine +
                    "Looks like you better search near the pub!";

                questCounter = 44;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. Ask inside the pub if someone has seen Mr. Mittens.");
                comboBox1.Items.Add("2. Search around the pub for Mr. Mittens.");
            }
            else if (questCounter + comboBox1.SelectedIndex == 45)
            {
                textBox1.Text = "It seems something has been causing some trouble in this area." + Environment.NewLine +
                    "There are a bunch of fish skeletons and crying children with scratches on their faces." + Environment.NewLine +
                    "This could be a collection of clues!";

                questCounter = 46;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. Follow the trail of scratched kids.");
                comboBox1.Items.Add("2. Follow the trail of fish skeletons.");
            }
            else if (questCounter + comboBox1.SelectedIndex == 47)
            {
                textBox1.Text = "You follow the skeletons to the local river." + Environment.NewLine +
                    "It seems that Mr. Mittens has somehow traveled across the river and is swiping fish while they swim on by." + Environment.NewLine +
                    "What do you do now?";

                questCounter = 50;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. Cross the river to get Mr. Mittens.");
                comboBox1.Items.Add("2. Tell the old lady you found her dumb cat.");
            }
            else if (questCounter + comboBox1.SelectedIndex == 50)
            {
                textBox1.Text = "Wait, how the hell did this cat get over there. There is no bridge or path!" + Environment.NewLine +
                    "How do you get across?";

                questCounter = 52;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. Swim?");
                comboBox1.Items.Add("2. Find a path to walk?");

            }
            else if (questCounter + comboBox1.SelectedIndex == 53)
            {
                textBox1.Text = "It took 20 minutes, but you finally found an area you could safely walk across." + Environment.NewLine +
                    "It seems in the meantime Mr. Mittens caught two more fish!" + Environment.NewLine +
                    "You bring him back to the old lady no worse for wear and get a cool looking Ring of Strength!"
                    + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 52)
            {
                textBox1.Text = "You swim across the river and get soaking wet. You manage to get Mr. Mittens and bring him to the other side." + Environment.NewLine +
                    "He is furious that you got him wet and left multiple scraches on your arms and face." + Environment.NewLine +
                    "You're lucky you don't need medical attention. For all your troubles, the old lady gives you a Ring of Strength!"
                    + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 51)
            {
                textBox1.Text = "While she is happy you found her cat, she isn't happy that you left him on the other side of a river." + Environment.NewLine +
                    "If you tried a little harder you could have gotten a reward, but you decided to be lazy instead."
                    + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 46)
            {
                textBox1.Text = "As it turns out, some random freak was running around town scratching the children..." + Environment.NewLine +
                    "Don't worry though, the person is already in jail but that means this was a dead end.";

                questCounter = 48;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. Try and find Mr. Mittens from here?.");
                comboBox1.Items.Add("2. Quit while you still have your sanity.");
            }
            else if (questCounter + comboBox1.SelectedIndex == 49)
            {
                textBox1.Text = "This may have been a wise choice in the long run." + Environment.NewLine +
                    "You no longer have to worry about sad old ladies or crazy cats" + Environment.NewLine + "You feel like you could lift 10 men with this ring!" + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 48)
            {
                textBox1.Text = "You try and search the area for Mr. Mittens and end up finding him in a dumpster." + Environment.NewLine +
                    "He smells atrocious as you drag him back to the old lady. She his happy you found him, but not happy about his stench." + Environment.NewLine +
                    "She hands you a Ring of Strength and tells you to run away since you still smell." + Environment.NewLine + "You feel like you could lift 10 men with this ring!" + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 44)
            {
                textBox1.Text = "As it turns out, Mr. Mittens is the center of attention in the pub!" + Environment.NewLine +
                    "You explain the situation and they agree to let you bring Mr. Mittens back home." + Environment.NewLine +
                    "The old lady is happy and decides that you deserve a reward. From her back pocket she gives you a " +
                    "Ring of Strength." + Environment.NewLine + "You feel like you could lift 10 men with this ring!" + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 42)
            {
                textBox1.Text = "It's obvious that the cat isn't in this area!" + Environment.NewLine +
                    "Well smart guy, you tried running off to some distant land to find her cat." + Environment.NewLine +
                    "It's a shame you didn't use all the information at your disposal." + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }

            else if (questCounter + comboBox1.SelectedIndex == 41)
            {
                textBox1.Text = "You're the boss.... It's a shame that this poor old lady won't ever see her cat again" + Environment.NewLine +
                    "It's actually super sad that nobody is helping her." + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            ///////// End of quest 4

            else if (questCounter + comboBox1.SelectedIndex == 4)
            {
                textBox1.Text = "A mystical, magical, and strange looking wizard lady asks for you to travel" +
                    "into the snowy mountians to find a magical artifact." + Environment.NewLine +
                    "Are you willing to embark on this dangerous quest?";

                questCounter = 60;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. Hell yeah! Magical artifacts are cool!");
                comboBox1.Items.Add("2. No. The snowy mountains have scary trolls.");
            }
            else if (questCounter + comboBox1.SelectedIndex == 60)
            {
                textBox1.Text = "You accept her offer and sprint off to the mountains. You love adventure and cannot wait" +
                    "to find this artifact." + Environment.NewLine + "Oh no! You finally find the artifact after hours of searching" +
                    " ,but it seems a frost troll is guarding it." + Environment.NewLine + "What do you do now?";

                questCounter = 62;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. Kill the troll");
                comboBox1.Items.Add("2. Lure it away");
                comboBox1.Items.Add("3. Go back home");
            }
            else if (questCounter + comboBox1.SelectedIndex == 62)
            {
                textBox1.Text = "You actually run up to this troll like a professional boxer and somehow beat it into submission." + Environment.NewLine +
                    "I don't know how this was possible.... but you did it." + Environment.NewLine +
                    "You return to the wizard lady with the artifact covered in troll blood. She doesn't ask any questions, but gives you an odd glance." + Environment.NewLine
                    + "She gives you the Wisdom of the Ancients as a reward!" + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 63)
            {
                textBox1.Text = "You throw some rocks in the other direction. Hopefully the troll is fooled for long enough." + Environment.NewLine +
                    "Should you just grab the artifact, or throw another rock and grab it?";

                questCounter = 65;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. Throw another rock and grab the artifact.");
                comboBox1.Items.Add("2. Grab the artifact and run.");
            }
            else if (questCounter + comboBox1.SelectedIndex == 65)
            {
                textBox1.Text = "It's a good thing you threw a second rock. The troll was just about to come back to the artifact." + Environment.NewLine +
                    "Because of your tactical genius, you manage to grab the artifact and get back home safe and sound." + Environment.NewLine +
                    "The Wizard lady is proud of you and gives you the Wisdom of the Ancients as a reward!" + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 66)
            {
                textBox1.Text = "The troll was on its way back and chases you down the mountain. You get to the gates just in time for the town guards to fight it." + Environment.NewLine +
                    "You get the artifact back to the Wizard lady and she bestows upon you the Wisdom of the Ancients" + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 64)
            {
                textBox1.Text = "Fighting a frost troll was not on the list of how you wanted to die." + Environment.NewLine +
                    "You go home to live another day." + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }

            ///////// End of quest 4

            else if (questCounter + comboBox1.SelectedIndex == 5)
            {
                textBox1.Text = "A shadowy figure has tasked you with killing the local Magistrate and as a reward you will earn some enchanted gauntlets." + Environment.NewLine +
                    "What do you do?";

                questCounter = 70;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. You need the equipment, so why not!");
                comboBox1.Items.Add("2. Ignore the quest");
            }
            else if (questCounter + comboBox1.SelectedIndex == 71)
            {
                textBox1.Text = "You are not some killer for hire." + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if (questCounter + comboBox1.SelectedIndex == 70)
            {
                textBox1.Text = "You need to somehow find a way into his home." + Environment.NewLine + "Along the path you find a ranger and a " +
                    "paladin that picked up a job offer to entertain his daughter!" + Environment.NewLine + "It's her birthday and this is the perfect " +
                    "chance, but faces you with a moral dilemma." + Environment.NewLine + "What happens now?";

                questCounter = 72;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. Inform the group about your plans to kill the Magistrate.");
                comboBox1.Items.Add("2. Keep your murder plot a secret.");
                comboBox1.Items.Add("3. Perform at the birthday party for that reward instead!");
                comboBox1.Items.Add("4. Leave now so the bad thoughts don't consume you.");
            }
            else if (questCounter + comboBox1.SelectedIndex == 73)
            {
                textBox1.Text = "A solid plan. They would probably be angry anyways. The Magistrate wants to see the performance before his daughter sees it" + Environment.NewLine +
                    "Now is your chance!";

                questCounter = 76;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. Attack him while he is distracted.");
                comboBox1.Items.Add("2. Inform him of the shadowy figure.");
            }
            else if (questCounter + comboBox1.SelectedIndex == 76)
            {
                textBox1.Text = "You manage to get two good stabs in before the goody two shoes paladin starts to heal him." + Environment.NewLine +
                    "What do you do now?";

                questCounter = 78;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. Keep stabbing him!");
                comboBox1.Items.Add("2. Run away!");

            }
            else if(questCounter + comboBox1.SelectedIndex == 79)
            {
                textBox1.Text = "Wait, how are you going to get out!?";

                questCounter = 82;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. Jump out the window!");
                comboBox1.Items.Add("2. Run out the door!");
            }
            else if(questCounter + comboBox1.SelectedIndex == 82)
            {
                textBox1.Text = "You manage to jump out of the window after the second attempt." + Environment.NewLine +
                    "Unfortuantly you didn't finish the job and don't get a reward because of it." + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if(questCounter + comboBox1.SelectedIndex == 83)
            {
                textBox1.Text = "You crash into two guards who drag you to jail. They lock you up for a week." + Environment.NewLine +
                    "Just in time for your fight with Papa Long Johns!" + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if(questCounter + comboBox1.SelectedIndex == 78)
            {
                textBox1.Text = "The Magistrate breathes his last breath and now you must escape!";

                questCounter = 80;

                comboBox1.Items.Clear();
                comboBox1.Update();
                comboBox1.ResetText();


                comboBox1.Items.Add("1. Jump out the window?");
                comboBox1.Items.Add("2. Run out the door?");
            }
            else if(questCounter + comboBox1.SelectedIndex == 80)
            {
                textBox1.Text = "It takes a few attempts but you manage to break and jump out the 2nd story window." + Environment.NewLine +
                    "You are sporting a sprained ankle, but you get away safely. You meet the shadowy figure and he gives you " +
                    "the gauntlets for a job well done." + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if(questCounter + comboBox1.SelectedIndex == 81)
            {
                textBox1.Text = "You crash into two guards who drag you to jail." + Environment.NewLine +
                    "They lock you up, but the shadowy figure breaks you out and gives you the gauntlets!" + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if(questCounter + comboBox1.SelectedIndex == 77)
            {
                textBox1.Text = "The Magistrate is shocked that someone would hire you to take his life." + Environment.NewLine +
                    "He shoves a pair of gauntlets int your arms and demands that you leave." + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if(questCounter + comboBox1.SelectedIndex == 74)
            {
                textBox1.Text = "You manage to pass the Magistrate's performance test and do a great job making a little girl happy on her birthday." + Environment.NewLine +
                    "You take your extra gold and buy a nice set of gauntlets." + Environment.NewLine + "( Press continue to continue )";
                questCounter = 1;
                comboBox1.SelectedIndex = -1;
            }
            else if(questCounter + comboBox1.SelectedIndex == 75)
            {
                textBox1.Text = "You leave the group before you get them in trouble or possibly killed." + Environment.NewLine +
                    "This was a massive waste of time." + Environment.NewLine + "( Press continue to continue )";
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
