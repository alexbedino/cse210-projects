using System;

public class EternalGoal: Goal
{

    public EternalGoal(String name, String description, int completionScore) : base(name, description, completionScore, 0)
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

    public override String Save()
    {
        return $"EternalGoal~||~{_name}~||~{_description}~||~{_completionScore}~||~{_numberOfTimesCompleted}";
    }

    public override int GetScore()
    {
        return _completionScore * _numberOfTimesCompleted;
    }

    public override bool IsComplete()
    {
        return false;
    }
}