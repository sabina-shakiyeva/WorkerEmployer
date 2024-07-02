namespace BOSS;

public class CV
{
    public CV(string profession, string school, string bal, List<string> skills, List<string> companies, DateOnly startDate, DateOnly finishDate, List<string> languages, bool diploma, string gitLink, string linkedIn)
    {
        Profession = profession;
        School = school;
        Bal = bal;
        Skills = skills;
        Companies = companies;
        StartDate = startDate;
        FinishDate = finishDate;
        Languages = languages;
        Diploma = diploma;
        GitLink = gitLink;
        LinkedIn = linkedIn;
    }

    public string Profession { get; set; }
    public string School { get; set; }
    public string Bal { get; set; }
    public List<string> Skills { get; set; }
    public List<string> Companies { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly FinishDate { get; set; }
    public List<string> Languages { get; set; }
    public bool Diploma { get; set; }
    public string GitLink { get; set; }
    public string LinkedIn { get; set; }

    public override string ToString() =>
        $"Profession:{Profession}, School:{School}, BAL: {Bal}, Skills: {string.Join(", ", Skills)},Companies:{string.Join(", ", Companies)}, Languages: {string.Join(",", Languages)}, Diploma: {Diploma}, GitHub: {GitLink}, LinkedIn: {LinkedIn}";
}