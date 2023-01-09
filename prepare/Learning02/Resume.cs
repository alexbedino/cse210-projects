public class Resume{
    public string _name = "";
    public List<Job> jobs = new List<Job>();

    public void Display(){
        Console.WriteLine($"{_name}");
        Console.WriteLine($"Jobs:");
        foreach (Job job in jobs){
            job._jobInformation(); 
            }
    }
}