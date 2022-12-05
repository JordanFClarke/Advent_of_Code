// See https://aka.ms/new-console-template for more information


internal class rockPaperScissors
{
    public rockPaperScissors()
    {
        using (var reader = new StreamReader(@"C:\Users\jordan.clarke\source\repos\Advent_of_Code\Advent_of_Code\rockPaperScissors.txt"))
        {
            this.matches = new List<RPSmatch>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                this.matches.Add(new RPSmatch(line));
            }
        }
    }
    public List<RPSmatch> matches;
    public class RPSmatch
    {
        public RPSmatch(string RPSstring)
        {
            this.RPSstring = RPSstring;
        }
        public string RPSstring;
        public int score
        {
            get
            {
                switch (RPSstring)
                {
                    case "A X":
                        return 3+1;
                    case "A Y":
                        return 6+2;
                    case "A Z":
                        return 0+3;
                    case "B X":
                        return 0+1;
                    case "B Y":
                        return 3+2;
                    case "B Z":
                        return 6+3;
                    case "C X":
                        return 6+1;
                    case "C Y":
                        return 0+2;
                    case "C Z":
                        return 3+3;
                    default:
                        return 100000000;

                }
            }
        }
        static public string decipher(string RPSstring)
        {
            switch (RPSstring)
            {
                case "A X":
                    return "A Z";
                case "A Y":
                    return "A X";
                case "A Z":
                    return "A Y";
                case "B X":
                    return "B X";
                case "B Y":
                    return "B Y";
                case "B Z":
                    return "B Z";
                case "C X":
                    return "C Y";
                case "C Y":
                    return "C Z";
                case "C Z":
                    return "C X";
                default:
                    return "Error :(";
            }
        }
    }
}