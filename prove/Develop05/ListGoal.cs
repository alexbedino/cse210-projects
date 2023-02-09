public class ListGoal : Goal
{
  // Properties of ListGoal
  private int _numberTimesComplete;
  private int _bonus;
   // Constructor of ListGoal
  public ListGoal(string name, string description, int completionScore, int timesComplete, int Bonus) : base(name, description, completionScore, Bonus)
  {
    _numberTimesComplete = timesComplete;
    _bonus = Bonus;
  }
   // Override method to display goal details
  public override string Display()
  {
    // Check if goal is completed
    string completeSymbol = IsComplete() ? "O" : " ";
     // Return goal details as a string
    return $"[{completeSymbol}] {_name}  ({_description}) -- Currently Complted: {_timescompleted}/{_numberTimesComplete}";
  }
   // Override method to increment number of times completed
  public override void DoGoal()
  {
    _timescompleted++;
  }
   // Override method to get total score
  public override int GetScore()
  {
    // Check if goal is complete and set bonus accordingly
    int completionBonus = IsComplete() ? _bonus : 0;
     // Calculate total score
    return (_score * _timescompleted) + completionBonus;
  }
   // Override method to check if goal is completed
  public override bool IsComplete()
  {
    // Return boolean result of comparison
    return _timescompleted == _numberTimesComplete;
  }
   // Override method to save data for goal
  public override string Save()
  {
    // Return goal details in a single string
    return $"ListGoal~||~{_name}~||~{_description}~||~{_score}~||~{_numberTimesComplete}~||~{_bonus}~||~{_timescompleted}";
  }
}
 