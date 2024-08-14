namespace FustionCalcTest;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a demon race to fuse.");
        //string demonRace1 = Console.ReadLine();
        Console.WriteLine("Enter the demon's level");
        int demonLevel1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a second demon race to fuse.");
        //string demonRace2 = Console.ReadLine();
        Console.WriteLine("Enter the second demon's level");
        int demonLevel2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"The resulting demon would be level {BasicMath(demonLevel1,demonLevel2)} of the " +
                          $"(race output).");
    }

    public static int RaceIdentify(string race)
    {
        int race_Id;
        switch (race.ToLower())
        {
            case "herald":
                return race_Id = 1;
            case "megami":
                return race_Id = 2;
            case "avian":
                return race_Id = 3; 
            case "divine":
                return race_Id = 4;
            case "yoma":
                return race_Id = 5;
            case "vile":
                return race_Id = 6;
            case "raptor":
                return race_Id = 7;
            case "deity":
                return race_Id = 8;
            case "wargod":
                return race_Id = 9;
            case "avatar":
                return race_Id = 10;
            case "holy":
                return race_Id = 11;
            case "genma":
                return race_Id = 12;
            case "fairy":
                return race_Id = 13;
            case "beast":
                return race_Id = 14;
            case "jirae":
                return race_Id = 15;
            case "fiend":
                return race_Id = 16;
            case "jaki":
                return race_Id = 17;
            case "wilder":
                return race_Id = 18;
            case "fury":
                return race_Id = 19;
            case "lady":
                return race_Id = 20;
            case "dragon":
                return race_Id = 21;
            case "kishin":
                return race_Id = 22;
            case "kunitsu":
                return race_Id = 23;
            case "femme":
                return race_Id = 24;
            case "brute":
                return race_Id = 25;
            case "fallen":
                return race_Id = 26;
            case "night":
                return race_Id = 27;
            case "snake":
                return race_Id = 28;
            case "tyrant":
                return race_Id = 30;
            case "drake":
                return race_Id = 31;
            case "haunt":
                return race_Id = 32;
            case "foul":
                return race_Id = 33;
            case "element":
                Console.WriteLine("Elemental mechaics are different from other races\nPlease input elemental name.");
                return -1;
            case "erthys":
                return race_Id = 100;
            case "aeros":
                return race_Id = 200;
            case "aquans":
                return race_Id = 300;
            case "flaemis":
                return race_Id = 400;
            default:
                Console.WriteLine("Invalid Race");
                return -1;
        }
    }

    public static int BasicMath(int level1, int level2)
    {
        int resultLevel = (level1 + level2) / 2;
        return resultLevel;
    }
}