using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using vampire;

namespace balldefender;

public static class Util
{
    public static Block?[] GenerateRow()
    {
        // generate a random number of blocks
        System.Random random = new Random();
        int limit = random.Next(3, 10);

        // Generate Unique Indexes for block row
        List<int> randomUniqueList = new List<int>();

        while (randomUniqueList.Count < limit)
        {
            var num = random.Next(11);
            if (!randomUniqueList.Contains(num))
                randomUniqueList.Add(num);
        }

        // Place blocks at Indexes for new row
        Block?[] BlockRow = new Block?[12];

        for (int i = 0; i < limit; i++)
            if (randomUniqueList.Contains(i))
            {
                BlockRow[i] = new Block();
                BlockRow[i].Position = new Vector2(i * 32, 0);
                BlockRow[i].AddComponent(new SpriteRenderer(Color.Tan, 32, 32));
                BlockRow[i].Collider = new Box(new(32, 32));
            }
            else
                BlockRow[i] = null;
        return BlockRow;
    }
}
