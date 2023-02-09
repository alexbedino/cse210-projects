public class ListGoal: Goal{
    private int _timesToComplete;
    private int _completionBonus;
    public ListGoal(String name, String description, int completionScore, int timesToComplete, int completionBonus): base(name, description, completionScore, completionBonus)
    {
        _timesToComplete = timesToComplete;
        _completionBonus = completionBonus;
    }
    public override String Display()
    {
        string completeSymbol = IsComplete() ? "X" : " ";
        return $"[{completeSymbol}] {_name}  ({_description}) -- Currently Complted: {_numberOfTimesCompleted}/{_timesToComplete}";
    }

    public override void DoGoal()
    {
        _numberOfTimesCompleted++;
    }

    public override int GetScore()
    {
        int completionBonus = IsComplete() ? _completionBonus : 0;
        return (_completionScore * _numberOfTimesCompleted) + completionBonus;
    }
    public override bool IsComplete()
    {
        return _numberOfTimesCompleted == _timesToComplete;
    }
    
    public override String Save()
    {
        return $"ListGoal~||~{_name}~||~{_description}~||~{_completionScore}~||~{_timesToComplete}~||~{_completionBonus}~||~{_numberOfTimesCompleted}";
    }
}