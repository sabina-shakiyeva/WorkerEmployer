
using BOSS;

class Program
{
    static void Main(string[] args)
    {

        List<Vacancy> vacancies = new List<Vacancy>();
        List<Worker> workers = new List<Worker>();
        List<Employer> employers = new List<Employer>();
        List<string> skills = new List<string>();
        List<string> companies = new List<string>();
        List<string> languages = new List<string>();
      
        companies.Add("microsoft");
        companies.Add("amazon");
        companies.Add("google");
        companies.Add("apple");
        skills.Add("c#");
        skills.Add("python");
        skills.Add("c++");
        languages.Add("english");
        languages.Add("azerbaijan");
        languages.Add("turkish");
        Vacancy vacancy1 = new Vacancy("developer", "analitik dusunce yuksek seviyyede proqram biliyi", 3, new DateOnly(2024, 7, 8));
        Vacancy vacancy2 = new Vacancy("designer", "corel-draw,photoshop", 4, new DateOnly(2024, 7, 8));
        vacancies.Add(vacancy1);
        vacancies.Add(vacancy2);

        Employer employer1 = new Employer(1, "Nargiz", "Aliyeva", "Nizami", "8732764", 28, "nargiz", "2233",vacancies);
        CV cv1 = new CV("programmer", "school 54", "440", skills, companies, new DateOnly(2022, 3, 2), new DateOnly(2023, 4, 5), languages, true, "sabina1", "sabina-shakiyeva");
        Worker worker1 = new Worker(1, "sabina", "shakiyeva", "absheron", "2374390", 19, "sabina", "1234", cv1);
        workers.Add(worker1);
        employers.Add(employer1);
        while (true)
        {
            Console.WriteLine("Worker yoxsa Isci olaraq daxil olmaq isteyirsiniz?");
            Console.WriteLine("Worker ucun 1 Employer ucun 2 duymesini sixin");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            if (choice == 1)
            {

                foreach (var worker in workers)
                {
                    if (worker.Name == username & worker.Password == password)
                    {

                        Console.WriteLine("Worker olaraq daxil oldunuz!, Movcud vakansiyalar:");
                        foreach (var vacancy in vacancies)
                        {
                            Console.WriteLine(vacancy.ToString());
                        }
                        Console.WriteLine("Muraciet etmek istediyiniz vazifenin adini yazin:");
                        string position = Console.ReadLine();
                        Vacancy VacancyApply = vacancies.Find(v => v.Position == position);
                        if(VacancyApply != null)
                        {
                            worker.Apply(VacancyApply);
                            Console.WriteLine($"Applied to{VacancyApply.Position}.");
                        }
                        else
                        {
                            Console.WriteLine("Vacancy not found");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Yanlis sifre ve ya parol");
                       
                    }
                }
            }
            else if(choice == 2)
            {
                Employer employer=employers.Find(e=> e.UserName == username && e.Password==password);
                if(employer != null)
                {
                    Console.WriteLine("Isci kimi daxil oldunuz.");
                    Console.WriteLine("1)Yeni vakansiya yarat");
                    Console.WriteLine("2)Vakansiyaya olan mwracietler");
                    int eChoice=int.Parse(Console.ReadLine());
                    if (eChoice == 1)
                    {
                        Console.WriteLine("Vezifenin adini daxil olun:");
                        string position=Console.ReadLine();
                        Console.WriteLine("Vezife haqqinda telebleri yazin:");
                        string requires=Console.ReadLine();
                        Console.WriteLine("Bos yerlerin sayi:");
                        int numberPositions=int.Parse(Console.ReadLine());
                        Console.WriteLine("Deadline-i daxil et(yyyy-mm-dd):");
                        DateOnly deadonline=DateOnly.Parse(Console.ReadLine());

                        Vacancy neww=new Vacancy(position, requires, numberPositions, deadonline);
                        //employer.Vacancies.Add(neww);
                        vacancies.Add(neww);

                        Console.WriteLine("Vakansiya yaradildi!");
                    }
                    else if(eChoice == 2) { 
                        Console.WriteLine("Muraciet edenleri gormek ucun vezifenin adini daxil edin:");
                        string position=Console.ReadLine();
                        Vacancy vacancyy=employer.Vacancies.Find(v=>v.Position==position);
                        if (vacancyy != null)
                        {
                            Console.WriteLine($"Muracietler {vacancyy.Position}:");
                            foreach(var application in  vacancyy.Applications)
                            {
                                Console.WriteLine(application.ToString());
                            }

                            Console.WriteLine("Tesdiqlemek ucun iscinin adini yazin:");
                            string workerName=Console.ReadLine();
                            Application applicationAccept=vacancyy.Applications.Find(ap=>ap.Worker.Name==workerName);
                            if (applicationAccept != null)
                            {
                                applicationAccept.Status = "Accepted";
                                Console.WriteLine($"{applicationAccept.Worker.Name}{applicationAccept.Worker.Surname} muraceti qebul olundu");
                            }
                            else
                            {
                                Console.WriteLine("Muraciet tapilmadi");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Vakansiya tapilmadi");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Yanlis secim");
                    }
                }
                else
                {
                    Console.WriteLine("Yanlis ad ve ya parol");
                }
              
            }
            else
            {
                Console.WriteLine("Yanlis secim.");
            }




        }
    }
}