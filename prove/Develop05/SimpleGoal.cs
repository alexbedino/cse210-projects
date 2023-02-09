public class SimpleGoal:Goal{
    private int _completionBonus;

    public SimpleGoal(String name, String description, int completionBonus): base(name, description, 0, completionBonus)
    {
       
    }

    public override String Display()
    {
        string completeSymbol = IsComplete() ? "X" : " ";
        return $"[{completeSymbol}] {_name}  ({_description})";
    }

   public override void DoGoal()
    {
        _numberOfTimesCompleted++;
    }
    public override int GetScore()
    {
        return _completionScore * _numberOfTimesCompleted;
    }

    public override bool IsComplete()
    {
        return _numberOfTimesCompleted == 1;
    }
    
    public override String Save()
    {
        return $"SimpleGoal~||~{_name}~||~{_description}~||~{_completionScore}~||~{_numberOfTimesCompleted}";
    }

}