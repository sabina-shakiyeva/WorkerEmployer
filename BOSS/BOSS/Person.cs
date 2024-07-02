namespace BOSS;

public class Person
{
    public Person(int id, string name, string surname, string sheher, string phone, int age, string username, string password)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Sheher = sheher;
        Phone = phone;
        Age = age;
        UserName = username;
        Password = password;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Sheher { get; set; }
    public string Phone { get; set; }
    public int Age { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}