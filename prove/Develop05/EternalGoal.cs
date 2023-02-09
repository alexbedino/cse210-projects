using System;

public class EternityGoal: Goal
{

    public EternityGoal(String name, String description, int completionScore) : base(name, description, completionScore, 0)
    {
        
    }

   
    public override String Display()
    {
        string completeSymbol = IsComplete() ? "O" : " ";
        return $"[{completeSymbol}] {_name}  ({_description})";
    }
    public override void DoGoal()
    {
        _timescompleted++;
    }

    public override String Save()
    {
        return $"Eternity Goal~||~{_name}~||~{_description}~||~{_score}~||~{_timescompleted}";
    }

    public override int GetScore()
    {
        return _score * _timescompleted;
    }

    public override bool IsComplete()
    {
        return false;
    }
}