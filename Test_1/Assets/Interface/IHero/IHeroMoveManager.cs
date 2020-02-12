using UnityEngine;
using System.Collections;

public interface IHeroMoveManager
{
    DataHero BASE
    {
        set;
        get;
    }
    void Move();

    void SkillQ();
    void SkillW();
    void SkillE();
    void SkillR();
}
