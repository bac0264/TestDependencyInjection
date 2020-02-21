using UnityEngine;
using System.Collections;

public class Akali : Hero
{
    public override DataHero BASE
    {
        get => base.BASE;
        set
        {
            base.BASE = value;
        }
    }
    public override void LateUpdate()
    {
        base.LateUpdate();
    }
    public override void Start()
    {
        base.Start();
    }
    public override void SetupInterface()
    {
        HeroMove = DIContainer.GetModule<IAkaliMoveManager>();
        base.SetupInterface();
    }
    public override void HeroDisplay()
    {
        Debug.Log("Akali");
    }
}
