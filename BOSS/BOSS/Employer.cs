
namespace BOSS;

public class Employer : Person
{


    public Employer(int id, string name, string surname, string sheher, string phone, int age, string username, string password, List<Vacancy> vacancies) : base(id, name, surname, sheher, phone, age, username, password)
    {
        Vacancies = vacancies;
    }

    public List<Vacancy> Vacancies { get; set; }
}