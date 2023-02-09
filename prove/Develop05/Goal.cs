 
using System;
 public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _score;
    protected int _timescompleted;
     // Constructor for Goal class 
    public Goal(string name, string description, int score, int completionScore) 
    {
        _name = name;
        _description = description;
        _score = completionScore;
    }
     // Abstract methods declaration
    public abstract string Display();
    public abstract void DoGoal();
    public abstract int GetScore();
    public abstract bool IsComplete();
    public abstract string Save();
}
