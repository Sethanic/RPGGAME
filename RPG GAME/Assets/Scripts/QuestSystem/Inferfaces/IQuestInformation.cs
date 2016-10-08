namespace QuestSystem
{
    public interface IQuestInformation
    {
        string Name { get; }
        string DescriptionSummary { get; }
        string Hint { get; }
        string Dialog { get; }
    }
}

