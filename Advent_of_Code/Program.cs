// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<carrierElf> ListOfElves = calorieCounting.carrierList();


//Day 1: Calorie Counting
int maxCals = 0;
List<int> topCals = new List<int>(3);

maxCals = GetMaxCals(ListOfElves, maxCals);
Console.WriteLine($"Day 1 solution: the elf with the most calories is carrying: {maxCals}");



static int GetMaxCals(List<carrierElf> ListOfElves, int maxCals)
{
    foreach (carrierElf elf in ListOfElves)
    {
        if (elf.carriedCalories > maxCals)
        {
            maxCals = elf.carriedCalories;
        }
        //Console.WriteLine(elf.carriedCalories);
    }
    return maxCals;
}