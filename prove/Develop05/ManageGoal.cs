using System;

public class ManageGoal
{

    private List<Goal> _goals = new List<Goal>();

    public ManageGoal()
    {

    }

    public void run()
    {
        List<String> mainMenuOptions = new List<String>();
        mainMenuOptions.Add("Create New Goal");
        mainMenuOptions.Add("List Goals");
        mainMenuOptions.Add("Save Goals");
        mainMenuOptions.Add("Load Goals");
        mainMenuOptions.Add("Record Event");
        Menu mainMenu;
        int menuOption = -1;
        while (menuOption != 0)
        {
            mainMenu = new Menu($"Current Score: {totalScore()}\n", "Menu Options:", mainMenuOptions);
            menuOption = mainMenu.Display();
            switch (menuOption)
            {
                case 1:
                    createNewGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    Save();
                    break;
                case 4:
                    Load();
                    break;
                case 5:
                    RecordEvent();
                    break;
                default:
                    break;
            }

        }

    }

    private void createNewGoal()
    {
        List<String> newGoalOptions = new List<String>();
        newGoalOptions.Add("Simple Goal");
        newGoalOptions.Add("Eternal Goal");
        newGoalOptions.Add("Checklist Goal");
        newGoalOptions.Add("Go Back");
        Menu newGoalMenu = new Menu("New Goal Menu", "The Types of Goals are:", newGoalOptions);
        int menuOption = newGoalMenu.Display(false);
        if (menuOption == 4)
            return;
        Console.Clear();
        String goalName = askAQuestion("What is the name of the goal?");
        String goalDescription = askAQuestion("What is a short description of the goal?");
        int goalWorkedScore = Int32.Parse(askAQuestion("How many points should be associated with this goal?"));

        switch (menuOption)
        {
            case 1:
                //String name, String description, int score, int completionScore
                _goals.Add(new SimpleGoal(goalName, goalDescription, goalWorkedScore));
                break;
            case 2:
                _goals.Add(new EternalGoal(goalName, goalDescription, goalWorkedScore));
                break;
            case 3:
                int timesGoalNeedsToBeCompleted = Int32.Parse(askAQuestion("How many times does this goal need to be accomplished for a bonus?"));
                int completionBonus = Int32.Parse(askAQuestion($"What is the bonus for accomplishing this goal {timesGoalNeedsToBeCompleted} times?"));
                _goals.Add(new ListGoal(goalName, goalDescription, goalWorkedScore, timesGoalNeedsToBeCompleted, completionBonus));
                break;
        }
    }


    private void ListGoals()
    {
        Console.Clear();
        Console.WriteLine("Goals");
        Console.WriteLine("-------------");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Display()}");
        }
        Console.WriteLine("-------------");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    private void RecordEvent()
    {
        List<Goal> uncompletedGoals = _goals.FindAll(goal => goal.IsComplete() == false);
        List<String> goalOptions = new List<String>();
        for (int i = 0; i < uncompletedGoals.Count; i++)
        {
            goalOptions.Add(uncompletedGoals[i].Display());
        }
        if (goalOptions.Count == 0)
        {
            Console.WriteLine("You have no goals to record an event for");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            return;
        }
        Menu newGoalMenu = new Menu("Record Event", "Which goal would you like to record an event for:", goalOptions);
        int menuOption = newGoalMenu.Display(false);
        uncompletedGoals[menuOption - 1].DoGoal();
    }

    private void Save()
    {
        string fileName = askAQuestion("What is the name of the file you would like to save to?");
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {
                sw.WriteLine(goal.Save());
            }
        }
    }

    private void Load()
    {
        string fileName = askAQuestion("What is the name of the file you would like to load?");
        _goals.Clear();
        using (StreamReader sr = new StreamReader(fileName))
        {
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                List<String> goalData = line.Split("~||~").ToList();
                Goal goalToAdd;
                switch (goalData[0])
                {
                    case "SimpleGoal":
                        //String name, String description, int score, int completionScore
                        goalToAdd = new SimpleGoal(goalData[1], goalData[2], Int32.Parse(goalData[3]));

                        break;
                    case "EternalGoal":
                        goalToAdd = new EternalGoal(goalData[1], goalData[2], Int32.Parse(goalData[3]));
                        break;
                    case "ListGoal":
                        goalToAdd = new ListGoal(goalData[1], goalData[2], Int32.Parse(goalData[3]), Int32.Parse(goalData[4]), Int32.Parse(goalData[5]));
                        break;
                    default:
                       throw new Exception("Invalid Goal Type");
                }
                for(int i = 0; i < Int32.Parse(goalData[goalData.Count-1]); i++)
                {
                    goalToAdd.DoGoal();
                }
                _goals.Add(goalToAdd);
            }
        }
    }

    private int totalScore()
    {
        int totalScore = 0;
        for (int i = 0; i < _goals.Count; i++)
        {
            totalScore += _goals[i].GetScore();
        }
        return totalScore;
    }

    private String askAQuestion(String question)
    {
        Console.WriteLine(question);
        Console.Write("> ");
        return Console.ReadLine();
    }
}