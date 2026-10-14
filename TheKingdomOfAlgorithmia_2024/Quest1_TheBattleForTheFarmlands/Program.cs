using Common;
using Quest1_TheBattleForTheFarmlands;
using System.Diagnostics;

var timer = new Stopwatch();
timer.Start();

///// PART 1
PlayPart1();
Console.WriteLine($"Total time spent: {timer.ElapsedMilliseconds} ms");
Console.WriteLine();
timer.Restart();

///// PART 2
PlayPart2();
Console.WriteLine($"Total time spent: {timer.ElapsedMilliseconds} ms");
Console.WriteLine();

////// PART 3
PlayPart3();
Console.WriteLine($"Total time spent: {timer.ElapsedMilliseconds} ms");
Console.WriteLine();

static void PlayPart1()
{
    Formatting.PrintStartQuest(1, "The Battle for the Farmlands", 1);
    
    string note = Notes.ReadNoteFromFile(1, 1);

    Console.WriteLine("We're being attacked!");
    int ancientAntsCount = note.Count(c => c == Creatures.ANCIENT_ANT);
    int badassBeetlesCount = note.Count(c => c == Creatures.BADASS_BEETLE);
    int creepyCockroachesCount = note.Count(c => c == Creatures.CREEPY_COCKROACH);

    Console.WriteLine($"Number of {Creatures.GetCreatureName(Creatures.ANCIENT_ANT)}: {ancientAntsCount}");
    Console.WriteLine($"Number of {Creatures.GetCreatureName(Creatures.BADASS_BEETLE)}: {badassBeetlesCount}");
    Console.WriteLine($"Number of {Creatures.GetCreatureName(Creatures.CREEPY_COCKROACH)}: {creepyCockroachesCount}");
    Console.WriteLine("Total number of creatures: " + (ancientAntsCount + badassBeetlesCount + creepyCockroachesCount));

    int totalHealthPotionsRequired = 0;
    foreach(var creature in note)
    {
        totalHealthPotionsRequired += Creatures.GetHealthPotionCount(creature);
    }

    Console.WriteLine($"Total number of health potions required: {totalHealthPotionsRequired}");
}

static void PlayPart2()
{
    Formatting.PrintStartQuest(1, "The Battle for the Farmlands", 2);

    string note = Notes.ReadNoteFromFile(1, 2);

    string[] creaturePairs = new string[note.Length / 2];
    for (int i = 0; i < note.Length; i += 2)
    {
        creaturePairs[i / 2] = note.Substring(i, 2);
    }

    Console.WriteLine("We're being attacked!");
    int ancientAntsCount = note.Count(c => c == Creatures.ANCIENT_ANT);
    int badassBeetlesCount = note.Count(c => c == Creatures.BADASS_BEETLE);
    int creepyCockroachesCount = note.Count(c => c == Creatures.CREEPY_COCKROACH);
    int diabolicalDragonfliesCount = note.Count(c => c == Creatures.DIABOLICAL_DRAGONFLY);
    int emptySpotsCount = note.Count(c => c == 'x');

    Console.WriteLine($"Number of {Creatures.GetCreatureName(Creatures.ANCIENT_ANT)}: {ancientAntsCount}");
    Console.WriteLine($"Number of {Creatures.GetCreatureName(Creatures.BADASS_BEETLE)}: {badassBeetlesCount}");
    Console.WriteLine($"Number of {Creatures.GetCreatureName(Creatures.CREEPY_COCKROACH)}: {creepyCockroachesCount}"); 
    Console.WriteLine($"Number of {Creatures.GetCreatureName(Creatures.DIABOLICAL_DRAGONFLY)}: {diabolicalDragonfliesCount}");
    Console.WriteLine("Total number of creatures: " + (ancientAntsCount + badassBeetlesCount + creepyCockroachesCount + diabolicalDragonfliesCount));
    Console.WriteLine("Total number of empty spots: " + emptySpotsCount);
    Console.WriteLine("Total attacking pairs: " + creaturePairs.Length);

    int totalHealthPotionsRequired = 0;
    foreach (var pair in creaturePairs)
    {
        totalHealthPotionsRequired += Creatures.GetHealthPotionCount(pair, 2);
    }

    Console.WriteLine($"Total number of health potions required: {totalHealthPotionsRequired}");
}

static void PlayPart3()
{
    Formatting.PrintStartQuest(1, "The Battle for the Farmlands", 3);

    string note = Notes.ReadNoteFromFile(1, 3);

    string[] creatureGroups = new string[note.Length / 3];
    for (int i = 0; i < note.Length; i += 3)
    {
        creatureGroups[i / 3] = note.Substring(i, 3);
    }

    Console.WriteLine("We're being attacked!");
    int ancientAntsCount = note.Count(c => c == Creatures.ANCIENT_ANT);
    int badassBeetlesCount = note.Count(c => c == Creatures.BADASS_BEETLE);
    int creepyCockroachesCount = note.Count(c => c == Creatures.CREEPY_COCKROACH);
    int diabolicalDragonfliesCount = note.Count(c => c == Creatures.DIABOLICAL_DRAGONFLY);
    int emptySpotsCount = note.Count(c => c == 'x');

    Console.WriteLine($"Number of {Creatures.GetCreatureName(Creatures.ANCIENT_ANT)}: {ancientAntsCount}");
    Console.WriteLine($"Number of {Creatures.GetCreatureName(Creatures.BADASS_BEETLE)}: {badassBeetlesCount}");
    Console.WriteLine($"Number of {Creatures.GetCreatureName(Creatures.CREEPY_COCKROACH)}: {creepyCockroachesCount}");
    Console.WriteLine($"Number of {Creatures.GetCreatureName(Creatures.DIABOLICAL_DRAGONFLY)}: {diabolicalDragonfliesCount}");
    Console.WriteLine("Total number of creatures: " + (ancientAntsCount + badassBeetlesCount + creepyCockroachesCount + diabolicalDragonfliesCount));
    Console.WriteLine("Total number of empty spots: " + emptySpotsCount);
    Console.WriteLine("Total attacking groups: " + creatureGroups.Length);

    int totalHealthPotionsRequired = 0;
    foreach (var group in creatureGroups)
    {
        totalHealthPotionsRequired += Creatures.GetHealthPotionCount(group, 3);
    }

    Console.WriteLine($"Total number of health potions required: {totalHealthPotionsRequired}");
}