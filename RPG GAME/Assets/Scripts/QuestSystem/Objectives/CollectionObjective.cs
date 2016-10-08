using UnityEngine;
using System.Collections;

namespace QuestSystem
{
    public class CollectionObjective : IQuestObjective
    {
        private string name;
        private string description;
        private bool isComplete;
        private bool isBonus;
        private string verb;
        private int collectionAmount; //total needed
        private int currentAmount; //current in inventory
        private Item collectionItem;
        /// <summary>
        /// This constructor builds a collection objective
        /// </summary>
        /// <param name="nameVerb">verb of quest type</param>
        /// <param name="totalAmount">amount of item needed to complete quest</param>
        /// <param name="item">the item needed to be collected</param>
        /// <param name="desc">about the quest, what to do, where, etc.</param>
        /// <param name="bonus">is it a bonus objective</param>
        public CollectionObjective(string nameVerb, int totalAmount, Item item, string desc, bool bonus)
        {
            name = nameVerb;// + " " + totalAmount + " " + collectionItem;
            verb = nameVerb;
            description = desc;
            collectionItem = item;
            collectionAmount = totalAmount;
            currentAmount = 0;
            isBonus = bonus;
            CheckProgress();
        }

        public string Name
        {
            get { return name; }
        }

        public string Description
        {
            get { return description; }
        }

        public int CollectionAmount
        {
            get { return collectionAmount; }
        }

        public int CurrentAmount
        {
            get { return currentAmount; }
        }

        public Item CollectionItem
        {
            get { return collectionItem; }
        }

        public void UpdateProgress()
        {
            throw new System.NotImplementedException();
        }

        public void CheckProgress()
        {
            if (currentAmount >= collectionAmount)
                isComplete = true;
            else
                isComplete = false;
        }

        public override string ToString()
        {
            return currentAmount + "/" + collectionAmount + " " + collectionItem;
        }


        public bool IsComplete
        {
            get { return isComplete; }
        }

        public bool IsBonus
        {
            get { return isBonus; }
        }
    }
}