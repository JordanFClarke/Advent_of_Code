// See https://aka.ms/new-console-template for more information


/* //Day 1: Calorie Counting
List<int> maxCals = new List<int>{5,4,3};
List<carrierElf> ListOfElves = calorieCounting.carrierList();
maxCals = GetMaxCals(ListOfElves, maxCals);
Console.WriteLine($"Day 1 solution: the elf with the most calories is carrying {maxCals[0]} calories");
Console.WriteLine($"Together, the top three elves are carrying {maxCals[0] + maxCals[1] + maxCals[2]} calories");


static List<int> GetMaxCals(List<carrierElf> ListOfElves, List<int> maxCals)
{
    int MaxID = 0;
    foreach (carrierElf elf in ListOfElves)
    {
        if (elf.carriedCalories > maxCals[2])
        {
            maxCals[2] = elf.carriedCalories;
            if (elf.carriedCalories > maxCals[1])
            {
                maxCals[2] = maxCals[1];
                maxCals[1] = elf.carriedCalories;
                if (elf.carriedCalories > maxCals[0])
                {
                    maxCals[1] = maxCals[0]; 
                    maxCals[0] = elf.carriedCalories;
                }
            }
        }
        //Console.WriteLine(elf.carriedCalories);
    }
    return maxCals;
}

*/

