namespace QuestSystem
{
    public interface IQuestObjective
    {
        string Name { get; }
        string Description { get; }
        bool IsComplete { get; }
        bool IsBonus { get; }
        void UpdateProgress();
        void CheckProgress();
    }
}