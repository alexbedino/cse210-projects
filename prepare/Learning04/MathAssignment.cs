public class MathAssignment:Assignment{

    private string _textbookSection;
    private string _problems;

    public MathAssignment(string textbookSection, string problems, string _studentName, string _topic) : base(_studentName, _topic){
        
        _textbookSection = textbookSection;
        _problems = problems;
    } 

    public string GetHomeworkList()
    {
        return "Student: " + _textbookSection + ", Topic: " + _problems;
    }

}