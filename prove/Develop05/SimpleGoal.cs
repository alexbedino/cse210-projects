public class EarthlyGoal: Goal {
  // Bonus that is rewarded when the goal is completed
  private int _completionBonus;
  // Constructor
  public EarthlyGoal(string name, string description, int completionBonus): base(name, description, 0, completionBonus) {
    // Set the completion bonus
    _completionBonus = completionBonus;
  }
  // Override the Display method of Goal
  public override string Display() {
    // Get a symbol indicating if the goal is complete and append it to the name and description of the goal
    string completeSymbol = IsComplete() ? "O" : " ";
    return $"[{completeSymbol}] {_name}  ({_description})";
  }
  // Override the DoGoal method of Goal
  public override void DoGoal() {
    // Increase the number of times the goal has been completed
    _timescompleted++;
  }
  // Override the GetScore method of Goal
  public override int GetScore() {
    // Return the score, based on how many times the goal has been completed
    return _score * _timescompleted;
  }
  // Override the IsComplete method of Goal
  public override bool IsComplete() {
    // Check if the goal has been completed once
    return _timescompleted == 1;
  }
  // Override the Save method of Goal
  public override string Save() {
    // Return a save string in the format "<ClassName>~||~<Name>~||~<Description>~||~<CompletionScore>~||~<NumberOfTimesCompleted>"
    return $"SimpleGoal~||~{_name}~||~{_description}~||~{_score}~||~{_timescompleted}";
  }
}