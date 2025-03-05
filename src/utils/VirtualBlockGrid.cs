/*using System;*/
/*using System.Collections.Generic;*/
/*using vampire;*/

namespace balldefender;

public class VirtualBlockGrid
{
  private Block?[,] segments;
  private int rows = 16;
  private int cols = 12;

  public VirtualBlockGrid()
  {
    segments = new Block?[rows, cols];
  }

  public void AddNewRow()
  {
    Block?[] NewRow = Util.GenerateRow();

    // shift each down
    for (int i = rows - 2; i >= 0; i--)
      for (int j = 0; j < cols; j++)
      {
        Block? block = segments[i + 1, j];
        block = segments[i, j];
        if (block != null)
          block.Position.X += 32;
      }

    for (int i = 0; i < cols; i++)
      segments[0, i] = NewRow[i];
  }

  public Block? this[int x, int y]
  {
    get => segments[x, y];
  }
}
