// See https://aka.ms/new-console-template for more information
public class calorieCounting
{
    public static List<carrierElf> carrierList()
    {
        using (var reader = new StreamReader(@"C:\Users\jordan.clarke\source\repos\Advent_of_Code\Advent_of_Code\calorieCounting.txt"))
        {
            List<carrierElf> elfList = new List<carrierElf>();
            int elfID = 0;
            carrierElf currentElf = new carrierElf(elfID);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                
                if (line != "")
                {
                    currentElf.carriedItems.Add(Int32.Parse(line));
                }
                else if (line == "")
                {
                    elfList.Add(currentElf);
                    elfID++;
                    currentElf = new carrierElf(elfID);
                }
            }
            return elfList;
        }
    }
}
public class carrierElf
{
    public carrierElf(int ID)
    {
        this.carriedItems = new List<int>();
        this.ID = ID;
    }
    public List<int> carriedItems;
    public int ID;
    public int carriedCalories => this.carriedItems.Sum();

}
