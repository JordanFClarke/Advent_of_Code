// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<carrierElf> ListOfElves = calorieCounting.carrierList();


//Day 1: Calorie Counting
int maxCals = 0;
foreach (carrierElf elf in ListOfElves)
{
    if (elf.carriedCalories > maxCals)
    {
        maxCals = elf.carriedCalories;
    }
    //Console.WriteLine(elf.carriedCalories);
}
Console.WriteLine(maxCals);


