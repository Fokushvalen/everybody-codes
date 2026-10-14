using System.Globalization;

namespace Quest1_TheBattleForTheFarmlands;

internal static class Creatures
{
    private static readonly Dictionary<char, int> creatureTypeHealthPotionMap = new()
    {
        { ANCIENT_ANT, 0 },
        { BADASS_BEETLE, 1 },
        { CREEPY_COCKROACH, 3 },
        { DIABOLICAL_DRAGONFLY, 5 }
    };

    internal const char ANCIENT_ANT = 'A';
    internal const char BADASS_BEETLE = 'B';
    internal const char CREEPY_COCKROACH = 'C';
    internal const char DIABOLICAL_DRAGONFLY = 'D';

    internal static int GetHealthPotionCount(char creatureType)
    {
        if (creatureTypeHealthPotionMap.TryGetValue(creatureType, out int healthPotionCount))
        {
            return healthPotionCount;
        }
        else
        {
            throw new ArgumentException($"Invalid creature type: {creatureType}");
        }
    }

    internal static int GetHealthPotionCount(string creatureGroup, int groupSize)
    {
        int totalHealthPotions = 0;
        int groupOf2Bonus = 1;
        int groupOf3Bonus = 2;

        if (creatureGroup.Length != groupSize)
        {
            throw new ArgumentException($"Creature group must consist of exactly {groupSize} creatures.");
        }

        for (int i = 0; i < groupSize; i++)
        {
            char creatureType = creatureGroup[i];
            if (creatureTypeHealthPotionMap.TryGetValue(creatureType, out int healthPotionCount))
            {
                totalHealthPotions += healthPotionCount;
            }
        }

        var emptySpotCount = creatureGroup.Count(type => type == 'x');
        if (groupSize == 2)
        {
            if (emptySpotCount == 0)
            {
                totalHealthPotions += groupOf2Bonus * groupSize;
            }
        }
        
        if (groupSize == 3) 
        {
            if (emptySpotCount == 0)
            {
                totalHealthPotions += groupOf3Bonus * groupSize;
            }
            else if (emptySpotCount == 1)
            {
                totalHealthPotions += groupOf2Bonus * (groupSize - emptySpotCount);
            }
        }

        return totalHealthPotions;
    }

    internal static string GetCreatureName(char creatureType)
    {
        return creatureType switch
        {
            ANCIENT_ANT => "Ancient Ant",
            BADASS_BEETLE => "Badass Beetle",
            CREEPY_COCKROACH => "Creepy Cockroach",
            DIABOLICAL_DRAGONFLY => "Diabolical Dragonfly",
            _ => throw new ArgumentException($"Invalid creature type: {creatureType}")
        };
    }
}
