using System;
using Microsoft.Xna.Framework;
/*using System.Collections.Generic;*/

using vampire;

namespace balldefender;

public class BallDefender : Scene
{
  public Engine Engine;
  public Ball Ball;
  public VirtualBlockGrid BGrid;

  public Block?[] GenRow;
  public int x;
  public int y;

  public override void Start()
  {

    if (BGrid == null)
    {
      BGrid = new VirtualBlockGrid();
      BGrid.AddNewRow();
    }

    // show health in terminal and add entity
    for (int i = 0; i < 16; i++)
    {
      Console.Write("\n");
      for (int j = 0; j < 12; j++)
      {
        if (BGrid[i, j] != null)
        {
          AddEntity(BGrid[i, j]);
          x = i;
          y = j;
          Console.Write(BGrid[i, j].health);
        }
        else
          Console.Write("n");
      }
    }
    Console.Write("\n");


    Ball Ball = new Ball(new Vector2(300, 300));
    /*Ball.AddComponent(new SpriteRenderer())*/
    Ball.Collider = new Circle(8);
    AddEntity(Ball);




    Engine.Instance.Scene = this;
    base.Start();
  }
}
