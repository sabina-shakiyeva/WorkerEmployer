namespace BOSS;

public class Worker : Person
{


    public Worker(int id, string name, string surname, string sheher, string phone, int age, string username, string password, CV workerCV) : base(id, name, surname, sheher, phone, age, username, password)
    {
        WorkerCV = workerCV;
        Applications = new List<Vacancy>();
    }

    public CV WorkerCV { get; set; }
    public List<Vacancy> Applications { get; set; }

    //public void Apply(Vacancy vacancy)
    //{
    //    Application application=new Application(this, WorkerCV,"Waiting");
    //    Applications.Add(vacancy);
    //    vacancy.Applications.Add(application);
    //}
    public void Apply(Vacancy vacancy)
    {
        if (Applications == null)
        {
            Applications = new List<Vacancy>();
        }

        if (vacancy.Applications == null)
        {
            vacancy.Applications = new List<Application>();
        }

        Application application = new Application(this, WorkerCV, "Waiting");
        Applications.Add(vacancy);
        vacancy.Applications.Add(application);
    }
}

