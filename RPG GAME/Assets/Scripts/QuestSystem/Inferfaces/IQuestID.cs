﻿using UnityEngine;
using System.Collections;

namespace QuestSystem
{
    public interface IQuestID
    {
        int ID { get; }
        int ChainQuestID { get; }
        int SourceID { get; }
    }
}