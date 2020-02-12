using UnityEngine;
using System.Collections;

public class Nami : Hero
{
    public override DataHero BASE { 
        get => base.BASE; 
        set {
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
        HeroMove = DIContainer.GetModule<INamiMoveManager>();
        base.SetupInterface();
    }
} 
