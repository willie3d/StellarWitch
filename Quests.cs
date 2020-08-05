using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quests
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }


        public Quests(int id,string name, string description,int rewardExpP,int rewardGold)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExpP;
            RewardGold = rewardGold;

            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}
