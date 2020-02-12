using UnityEngine;
using System.Collections;

public class AkaliVer_1 : IAkaliMoveManager
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
        Debug.Log("AkaliVer_1: Run");
    }

    public void SkillE()
    {
        Debug.Log("AkaliVer_1: Phi tiêu");
    }

    public void SkillQ()
    {
        Debug.Log("AkaliVer_1: Bắn 3 phi tiêu");
    }

    public void SkillR()
    {
        Debug.Log("AkaliVer_1: Lướt");
    }

    public void SkillW()
    {
        Debug.Log("AkaliVer_1: Bom khói");
    }
}
