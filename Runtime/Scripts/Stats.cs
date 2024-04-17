using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Stat
{
    public int Strength;
    public int Wisdom;
    public int Charisma;

    public Stat(int Strength, int Wisdom, int Charisma)
    {
        this.Charisma = Charisma;
        this.Strength = Strength;
        this.Wisdom = Wisdom;
    }
    public Stat() { }

}


