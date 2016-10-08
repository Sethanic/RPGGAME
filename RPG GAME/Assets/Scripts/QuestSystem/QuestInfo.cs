using UnityEngine;
using System.Collections.Generic;
using System.IO;
using LitJson;

namespace QuestSystem
{
    public class QuestInfo
    {
        private List<Quest> database = new List<Quest>();
        private JsonData questData;
        SaveInformation information;

        void Start ()
        {
            questData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/Quests.json"));
            Quest();
            information.Save();
        }

        void Quest()
        {
            for (int i = 0; i < questData.Count; i++)
            {
                database.Add(new Quest((int)questData[i]["id"],
                (bool)questData[i]["condition"],
                questData[i]["type"].ToString(),
                questData[i]["name"].ToString(),
                questData[i]["description"].ToString()));
            }
        }

        private List<IQuestObjective> objectives;

        private bool IsComplete()
        {
            for (int i = 0; i < objectives.Count; i++)
			{
                if (!objectives[i].IsComplete && !objectives[i].IsBonus)
                {
                    return false;
                }

			}
            return true;
        }
    }

    public class Quest
    {
        public int ID { get; set; }
        public bool Condition { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Quest(int id, bool condition, string type, string name, string description)
        {
            this.ID = id;
            this.Condition = condition;
            this.Type = type;
            this.Name = name;
            this.Description = description;
        }
    }
}


