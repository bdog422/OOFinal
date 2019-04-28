using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int QuestID { get; set; }
        public string QuestName { get; set; }

        public void MakeQuests(int id)
        {
            if(id == 1)
            {
                QuestName = "A drinking contest with a dwarf";
            }
            else if(id == 2)
            {
                QuestName = "The great bet money heist";
            }
            else if (id == 3)
            {
                QuestName = "The runaway";
            }
            else if (id == 4)
            {
                QuestName = "The magical artifact";
            }
            else if (id == 5)
            {
                QuestName = "The Magistrate issue";
            }
        }
    }
}
