using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamiVer_1 : INamiMoveManager
{
    private DataHero data;
    public DataHero BASE
    {
        set
        {
            data = value;
        }
        get
        {
            return data;
        }
    }
    public void Move()
    {
        Debug.Log("NameVer1: move Slow");
        // Do somthing with data hero
    }

    public void SkillE()
    {
        Debug.Log("NameVer1: Skill E buff hp");
        // Do somthing with data hero
    }

    public void SkillQ()
    {
        Debug.Log("NameVer1: Skill Q buff dame");
        // Do somthing with data hero
    }

    public void SkillR()
    {
        Debug.Log("NameVer1: Skill R buff mana");
        // Do somthing with data hero
    }

    public void SkillW()
    {
        Debug.Log("NameVer1: Skill W buff power");
        // Do somthing with data hero
    }
}
