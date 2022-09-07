using KordamineOOP;
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");
Koer koer = new Koer(Koer.toug.Mops, "Šarik", "punane", Koduloom.sugu.isane, 35.5, 7);
koer.print_Info();
koer.print_Haal();
Koer veelkoer = new Koer(koer);
veelkoer.muudaNimi("Mopsjara");
veelkoer.muudaVarv("valge");
veelkoer.muudaSugu(Koduloom.sugu.isane);
veelkoer.muudaKaal(7.2);
veelkoer.muudaVanus(3);
veelkoer.print_Info();
Console.WriteLine("----------------------------------------------------------------------------");
//Raccoon
Raccoon raccoonMaksim = new Raccoon(Raccoon.tougR.Eastern_raccoon, "Maksim", "black", Koduloom.sugu.isane, 10, 4, "8/10");
Raccoon raccoonLjoha = new Raccoon(Raccoon.tougR.Florida_raccoon, "Ljoha", "gray", Koduloom.sugu.isane, 15, 5, "10/10");
Raccoon raccoonAndrei = new Raccoon(Raccoon.tougR.Texas_raccoon, "Andrei", "black", Koduloom.sugu.isane, 13, 3, "5/10");
raccoonMaksim.print_Info();
raccoonMaksim.print_Haal();
Console.WriteLine(raccoonMaksim.print_Info());

List<Koduloom> raccoonList = new List<Koduloom>();
raccoonList.Add(raccoonMaksim);
raccoonList.Add(raccoonLjoha);
raccoonList.Add(raccoonAndrei);

using (StreamWriter writer = new StreamWriter("C:\\Users\\opilane\\source\\repos\\Artem Stryzhakov TARpv20\\raccoon.txt"))
{
    Console.WriteLine("\n----Raccoon----");
	foreach (Koduloom Object in raccoonList)
	{
        writer.WriteLine($"{Object.nimi}, {Object.loomaSugu}, {Object.vanus}, {Object.nahaalsus}");
    }
}

List<Raccoon> raccoons = new List<Raccoon>();

using (StreamReader reader = new StreamReader("C:\\Users\\opilane\\source\\repos\\Artem Stryzhakov TARpv20\\raccoon.txt"))
{
    string text;
    while ((text = reader.ReadLine()) != null)
    {
        string[] row = text.Split(',');
        raccoons.Add(new Raccoon(row[0], ConvertToEnum(row[1]), Convert.ToInt32(row[2]), row[3]));
    }

    foreach (var item in raccoons)
    {
        Console.WriteLine($"Nimi: {item.nimi}, Sugu: {item.loomaSugu}, Vanus: {item.vanus}, Nahaalsus: {item.nahaalsus}");
    }
}

Koduloom.sugu ConvertToEnum(string data)
{
    if (data == " isane")
    {
        return Koduloom.sugu.isane;
    }
    else
    {
        return Koduloom.sugu.emane;
    }
}