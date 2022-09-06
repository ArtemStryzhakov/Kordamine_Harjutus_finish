// See https://aka.ms/new-console-template for more information
using Kordamine_Harjutus;

Tootaja tootaja = new Tootaja("Mihkail", 1981, Tootaja.sugu.isane, "TTHK", "Programmer", 1600);
Opilane opilane = new Opilane("Genadij", 2004, Opilane.sugu.isane, "Keila kool", "TARpv20", "Physical education");
Kutsekooliopilane kutseop = new Kutsekooliopilane("Elise", 2000, Opilane.sugu.emane, "TTHK", "Designer", 3);
tootaja.print_Info();
opilane.print_Info();
kutseop.print_Info();

Tootaja worker = new Tootaja(tootaja);
Opilane student = new Opilane(opilane);
Kutsekooliopilane PrStudent = new Kutsekooliopilane(kutseop);
changeName();
studentChanges();
kutseOpilaneChanges();

void changeName()
{ 
    Console.Write("\nWanna change the name? (yes/no): ", Console.ForegroundColor = ConsoleColor.Yellow);
    string answer = Console.ReadLine();
    if (answer == "yes")
    {
        Console.Write("Whose name? (Student - 1/Worker - 2/Vocational school student - 3): ", Console.ForegroundColor = ConsoleColor.Yellow);
        int answerWho = Convert.ToInt32(Console.ReadLine());
        Console.Write("Write new name: ", Console.ForegroundColor = ConsoleColor.Yellow);
        string answerName = Console.ReadLine();
        if (answerWho == 1)
        {   
            student.muudaNimi(answerName);
            student.print_Info();
        }
        else if (answerWho == 2)
        {
            worker.muudaNimi(answerName);
            worker.print_Info();
        }
        else if(answerWho == 3)
        {
            PrStudent.muudaNimi(answerName);
            PrStudent.print_Info();
        }
    }
    else {
        Console.WriteLine("No changes", Console.ForegroundColor = ConsoleColor.DarkRed);
    }
}

void studentChanges()
{
    Console.Write("\nWanna change student school? (yes/no): ", Console.ForegroundColor = ConsoleColor.Yellow);
    string answerS = Console.ReadLine();
    if (answerS == "yes")
    {
        Console.Write("Write new school: ", Console.ForegroundColor = ConsoleColor.Yellow);
        string newSchool = Console.ReadLine();
        student.muudaKooli(newSchool);
        student.print_Info();
    }
    else {
        Console.WriteLine("No changes", Console.ForegroundColor = ConsoleColor.DarkRed);
    }

    Console.Write("\nWanna change student gender? (yes/no): ", Console.ForegroundColor = ConsoleColor.Yellow);
    answerS = Console.ReadLine();
    if (answerS == "yes")
    {
        var isane = Isik.sugu.isane;
        var emane = Isik.sugu.emane;
        List<Isik.sugu> variables = new List<Isik.sugu>() { isane, emane };
        Console.Write("Write gender (isane - 1/emane - 2): ");
        int genderAn = Convert.ToInt32(Console.ReadLine());
        try
        {
            student.muudaSugu(variables[genderAn - 1]);
            student.print_Info();
        }
        catch (Exception)
        {
            Error();
        }
    }
    else {
        Console.WriteLine("No changes", Console.ForegroundColor = ConsoleColor.DarkRed);
    }
}

void kutseOpilaneChanges()
{
    Console.Write("\nWanna change place of study? (yes/no): ", Console.ForegroundColor = ConsoleColor.Yellow);
    string answerP = Console.ReadLine();
    if (answerP == "yes")
    {
        Console.Write("Write a new place: ", Console.ForegroundColor = ConsoleColor.Yellow);
        string ansPlace = Console.ReadLine();
        PrStudent.muudaPlace(ansPlace);
    }
    else {
        Console.WriteLine("No changes", Console.ForegroundColor = ConsoleColor.DarkRed);
    }

    Console.Write("Wanna change profession? (yes/no): ", Console.ForegroundColor = ConsoleColor.Yellow);
    string answerPr = Console.ReadLine();
    if (answerPr == "yes")
    {
        Console.Write("Write a new profession: ", Console.ForegroundColor = ConsoleColor.Yellow);
        string ansPlace = Console.ReadLine();
        PrStudent.muudaProf(ansPlace);
    }
    else
    {
        Console.WriteLine("No changes", Console.ForegroundColor = ConsoleColor.DarkRed);
    }

    Console.Write("Wanna change kurse? (yes/no): ", Console.ForegroundColor = ConsoleColor.Yellow);
    string answerK = Console.ReadLine();
    if (answerK == "yes")
    {
        Console.Write("Write a new kurse (number: 1 - 3): ", Console.ForegroundColor = ConsoleColor.Yellow);
        int ansKurs = Convert.ToInt32(Console.ReadLine());
        PrStudent.muudaKurs(ansKurs);
    }
    else
    {
        Console.WriteLine("No changes", Console.ForegroundColor = ConsoleColor.DarkRed);
    }
    PrStudent.print_Info();
}

void Error()
{
    Console.WriteLine(@"|-----   ----    ----     /---\   ----  ", Console.ForegroundColor = ConsoleColor.Red);
    Console.WriteLine(@"|        |   |   |   |   |     |  |   | ", Console.ForegroundColor = ConsoleColor.Red);
    Console.WriteLine(@"|-----   |---    |---    |     |  |---  ", Console.ForegroundColor = ConsoleColor.Red);
    Console.WriteLine(@"|        |   \   |   \   |     |  |   \ ", Console.ForegroundColor = ConsoleColor.Red);
    Console.WriteLine(@"|-----   |    \  |    \   \___/   |    \", Console.ForegroundColor = ConsoleColor.Red);
}