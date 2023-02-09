using System;

public abstract class Goal{

    protected String _name;
    protected String _description;
    protected int _completionScore;
    protected int _numberOfTimesCompleted;

    public Goal(String name, String description, int score, int completionScore){
        _name = name;
        _description = description;
        _completionScore = completionScore;
    }
    
    public abstract String Display();

   public abstract void DoGoal();

   public abstract int GetScore();

   public abstract bool IsComplete();

   public abstract String Save();
}