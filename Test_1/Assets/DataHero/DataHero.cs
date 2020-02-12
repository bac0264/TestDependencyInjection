using UnityEngine;
using System.Collections;

[SerializeField]
public class DataHero
{
    public string name;
    public float dame;
    public float speed;
    public DataHero()
    {
        name = "default";
        dame = 0;
        speed = 0;
    }
    public DataHero(string name, float dame, float speed)
    {
        this.name = name;
        this.dame = dame;
        this.speed = speed;
    }

}
