using System;

class Ali
{
    public static void Main()
    {
        Costumer C1 = new Costumer();
        C1.ID = 101;
        C1.Name = "John Lorusso";
        C1.Salary = 5000;

        Costumer C2 = new Costumer();
        C2.ID = 102;
        C2.Name = "Ibrahim Arabaki";
        C2.Salary = 6000;

        Costumer C3 = new Costumer();
        C3.ID = 103;
        C3.Name = "UFO";
        C3.Salary = 7000;

        Dictionary<int, Costumer> DC = new Dictionary<int, Costumer>();
        DC.Add(C1.ID, C1);
        DC.Add(C2.ID, C2);
        DC.Add(C3.ID, C3);

        Console.WriteLine("Printing using Key");
        Console.WriteLine("----------------------------------------------------------------");

        Costumer C101 = DC[101];
        Costumer C102 = DC[102];
        Costumer C103 = DC[103];


        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", C101.ID, C101.Name, C101.Salary);
        Console.WriteLine("----------------------------------------------------------------");

        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", C102.ID, C102.Name, C102.Salary);
        Console.WriteLine("----------------------------------------------------------------");

        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", C103.ID, C103.Name, C103.Salary);
        Console.WriteLine("----------------------------------------------------------------");

        Console.WriteLine("Printing using foreach Loop (KeyValuePair) --- Preferrable");

        foreach (KeyValuePair<int, Costumer> CKVP in DC)
        {
            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine("Key = {0}", CKVP.Key);

            Costumer C = CKVP.Value;
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", C.ID, C.Name, C.Salary);
        }

        Console.WriteLine("Printing using foreach Loop (var)");

        foreach (var CKVP in DC)
        {
            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine("Key = {0}", CKVP.Key);

            Costumer C = CKVP.Value;
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", C.ID, C.Name, C.Salary);
        }
    }
}

public class Costumer
{
    public int ID {get; set; }
    public string Name {get; set; }
    public int Salary {get; set; }
}