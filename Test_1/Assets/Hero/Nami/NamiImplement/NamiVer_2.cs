using UnityEngine;
using System.Collections;

public class NamiVer_2 : INamiMoveManager
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
        Debug.Log("NameVer2: move faster - NamiVer1");
        // Do somthing with data hero
    }

    public void SkillE()
    {
        Debug.Log("NameVer2: Skill E buff HP thay bằng skill định hướng gây dame");
        // Do somthing with data hero
    }

    public void SkillQ()
    {
        Debug.Log("NameVer2: Skill Q buff dame thay bằng skill buff speed");
        // Do somthing with data hero
    }

    public void SkillR()
    {
        Debug.Log("NameVer2: Skill R buff mana thay bằng skill sóng thần");
        // Do somthing with data hero
    }

    public void SkillW()
    {
        Debug.Log("NameVer2: Skill W buff power thay bằng skill tăng tốc độ đánh");
        // Do somthing with data hero
    }
}
