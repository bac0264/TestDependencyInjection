using UnityEngine;
using System.Collections;
using System;

public class Hero : MonoBehaviour
{
    private DataHero dataHero;
    public IHeroMoveManager HeroMove;
    public virtual DataHero BASE
    {
        set
        {
            dataHero = value;
        }
        get
        {
            return dataHero;
        }
    }
    public virtual void Start()
    {
        SetupInterface();
    }
    public virtual void LateUpdate()
    {
        if (Input.GetKey("up") || Input.GetKey("down") || Input.GetKey("left") || Input.GetKey("right"))
        {
            HeroMove.Move();
        }
        if (Input.GetKey("w"))
        {
            HeroMove.SkillW();
        }
        if (Input.GetKey("e"))
        {
            HeroMove.SkillE();
        }
        if (Input.GetKey("r"))
        {
            HeroMove.SkillR();
        }
        if (Input.GetKey("q"))
        {
            HeroMove.SkillQ();
        }
    }
    public virtual void SetupInterface()
    {
        if (HeroMove != null) HeroMove.BASE = BASE;
    }
    public virtual void HeroDisplay()
    {
        Debug.Log("Hero default");
    }
}
