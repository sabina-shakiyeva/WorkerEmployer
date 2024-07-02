namespace BOSS;

public class Application
{
    public Application(Worker worker, CV cV, string status)
    {
        Worker = worker;
        CV = cV;
        Status = "Waiting";
    }

    public Worker Worker { get; set; }
    public CV CV { get; set; }
    public string Status { get; set; }
    public override string ToString() => $"Worker: {Worker.Name} {Worker.Surname}, Status: {Status}, CV: {CV}";
}
