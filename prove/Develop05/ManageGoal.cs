public class ManageGoal {

  private List < Goal > _goals = new List < Goal > ();

  public ManageGoal() {}


 public void start() {
    List < String > menuOptions = new List < String > ();
    // Adding main menu options
    menuOptions.Add("New Goal Creation");
    menuOptions.Add("Goals List");
    menuOptions.Add("Save");
    menuOptions.Add("Load");
    menuOptions.Add("Add something you did");
    // Initializing Menu instance
    Menu mainMenu;
    int menuOption = -1;
    // Main while loop
    while (menuOption != 0) {
      // Displaying the menu with current score
      mainMenu = new Menu($"Current Score: {totalScore()}\n", "Menu Options:", menuOptions);
      menuOption = mainMenu.Display();
      // different switch cases for every option of menu
      switch (menuOption) {
      case 1:
        GoalNew();
        break;
      case 2:
        GoalsList();
        break;
      case 3:
        Save();
        break;
      case 4:
        Load();
        break;
      case 5:
        Annotate();
        break;
      default:
        break;
      }
    }
  }

 private void GoalNew() {
    List < String > newGoalChoice = new List < String > ();
    newGoalChoice.Add("Regular Goal");
    newGoalChoice.Add("Eternity Goal");
    newGoalChoice.Add("Checklist Goal");
    newGoalChoice.Add("Back");
    Menu newGoalMenu = new Menu("New Goal Menu", "The Types of Goals are:", newGoalChoice);
    int menuOption = newGoalMenu.Display(false);
    if (menuOption == 4)
      return;
    Console.Clear();
    String goalName = askAQuestion("Enter the goal name");
    String goalDescription = askAQuestion("Write the goal description for reference");
    int goalWorkedScore = Int32.Parse(askAQuestion("Number of points associated with the goal"));

    switch (menuOption) {
    case 1:
      //String name, String description, int score, int completionScore
      _goals.Add(new EarthlyGoal(goalName, goalDescription, goalWorkedScore));
      break;
    case 2:
      _goals.Add(new EternityGoal(goalName, goalDescription, goalWorkedScore));
      break;
    case 3:
      int timesGoalNeedsToBeCompleted = Int32.Parse(askAQuestion("To get a bonus how many times you have to accomplish this goal?"));
      int completionBonus = Int32.Parse(askAQuestion($"Establish a bonus for completing the goal: {timesGoalNeedsToBeCompleted}"));
      _goals.Add(new ListGoal(goalName, goalDescription, goalWorkedScore, timesGoalNeedsToBeCompleted, completionBonus));
      break;
    }
  }

  private void Annotate() {
    List < Goal > uncompletedGoals = _goals.FindAll(goal => goal.IsComplete() == false);
    List < String > goalOptions = new List < String > ();
    for (int i = 0; i < uncompletedGoals.Count; i++) {
      goalOptions.Add(uncompletedGoals[i].Display());
    }
    if (goalOptions.Count == 0) {
      Console.WriteLine("You have no goals to record an event for");
      Console.WriteLine("Press space bar to continue");
      Console.ReadKey();
      return;
    }
    Menu newGoalMenu = new Menu("Record Event", "Which goal would you like to record an event for:", goalOptions);
    int menuOption = newGoalMenu.Display(false);
    uncompletedGoals[menuOption - 1].DoGoal();
  }

  private void GoalsList() {
    // Clear the console output 
    Console.Clear();
    // Show the title for the list 
    Console.WriteLine("Goals");
    Console.WriteLine("-------------");
    // Iterate and display each goal in the list 
    for (int i = 0; i < _goals.Count; i++) {
      Console.WriteLine($"{i + 1}. {_goals[i].Display()}");
    }
    // Display footer for this output 
    Console.WriteLine("-------------");
    Console.WriteLine("Press space to continue");
    // Read a key from the user to wait for them to finish viewing  
    Console.ReadKey();
  }

  private void Save() {
    string fileName = askAQuestion("Name of the destination file to save to");
    using(StreamWriter sw = new StreamWriter(fileName)) {
      foreach(Goal goal in _goals) {
        sw.WriteLine(goal.Save());
      }
    }
  }

  private void Load() {
    string fileName = askAQuestion("Name of the file to load from");
    _goals.Clear();
    using(StreamReader sr = new StreamReader(fileName)) {
      String line;
      while ((line = sr.ReadLine()) != null) {
        List < String > goalData = line.Split("~||~").ToList();
        Goal goalToAdd;
        switch (goalData[0]) {
        case "SimpleGoal":
          //String name, String description, int score, int completionScore
          goalToAdd = new EarthlyGoal(goalData[1], goalData[2], Int32.Parse(goalData[3]));

          break;
        case "EternalGoal":
          goalToAdd = new EternityGoal(goalData[1], goalData[2], Int32.Parse(goalData[3]));
          break;
        case "ListGoal":
          goalToAdd = new ListGoal(goalData[1], goalData[2], Int32.Parse(goalData[3]), Int32.Parse(goalData[4]), Int32.Parse(goalData[5]));
          break;
        default:
          throw new Exception("Invalid Goal Type");
        }
        for (int i = 0; i < Int32.Parse(goalData[goalData.Count - 1]); i++) {
          goalToAdd.DoGoal();
        }
        _goals.Add(goalToAdd);
      }
    }
  }

  private int totalScore() {
    int totalScore = 0;
    for (int i = 0; i < _goals.Count; i++) {
      totalScore += _goals[i].GetScore();
    }
    return totalScore;
  }

  private String askAQuestion(String question) {
    Console.WriteLine(question);
    Console.Write(":: ");
    return Console.ReadLine();
  }
}