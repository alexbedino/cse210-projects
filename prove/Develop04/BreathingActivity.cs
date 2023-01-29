class BreathingActivity : Activity
{

    private int _inhale;

private int _exhale;

private string _InhaleMessage;

private string _ExhaleMessage;
public BreathingActivity() : base("Breathing Activity", "This activity will help you to focus on your breathing")
{
    _InhaleMessage = "Inhale";
    _ExhaleMessage = "Exhale";
}

public void Begin(){

    Welcome();

    Console.Write("How long do you want to inhale? ");
    _inhale = Convert.ToInt32(Console.ReadLine());

    Console.Write("How long do you want to exhale? ");
    _exhale = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Press enter to begin ");
    Console.ReadKey();

    BreathInBreathOut();

    EndActivity();

    
}


private void BreathInBreathOut(){
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    string stage = "Inhale";

    DateTime nextStageChange = ( DateTime.Now).AddSeconds(_inhale);
    bool messageDisplayed1 = false;
    bool messageDisplayed2 = false;
    while( DateTime.Now < endTime){ 
    
        if(stage == "Inhale"){
        if (!messageDisplayed1) {
        Console.WriteLine("Now, Inhale");
        messageDisplayed1 = true;
    } 
            ShowSpinner(_inhale);
        }else{
        if (!messageDisplayed2) {
        Console.WriteLine("Now, Exhale");
        messageDisplayed2 = true;
    } 
            ShowSpinner(_exhale);
        }
        if( DateTime.Now > nextStageChange){
            if(stage == "Inhale"){
                stage = "Exhale";
                nextStageChange =  ( DateTime.Now).AddSeconds(_exhale);
            }else{
                stage = "Inhale";
                nextStageChange =  ( DateTime.Now).AddSeconds(_inhale);
            }
        }            
        Thread.Sleep(24);
    }
}

}