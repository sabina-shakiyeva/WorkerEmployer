namespace BOSS;

public class Vacancy
{
    public Vacancy(string position, string description, int numberOfPositions, DateOnly deadline)
    {
        Position = position;
        Description = description;
        NumberOfPositions = numberOfPositions;
        Deadline = deadline;
    }

    public string Position { get; set; }
    public string Description { get; set; }
    public int NumberOfPositions { get; set; }
    public DateOnly Deadline { get; set; }
    public List<Application> Applications { get; set; }
    public override string ToString() => $"Position:{Position} ,\nDescription:{Description},\nNumberOfPositions:{NumberOfPositions},\nDeadline:{Deadline}\n";
}