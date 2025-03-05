/*using Microsoft.Xna.Framework;*/
using System;
using vampire;

namespace balldefender;

public class Block : Entity
{
    public int health;
    public int horizontalPosition;

    public Block()
    {
        Random rnd = new Random();
        health = rnd.Next(1, 9);
    }

}
