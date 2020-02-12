using UnityEngine;
using System.Collections;

public class TestDataHero : MonoBehaviour
{
    public Hero hero;
    private void Awake()
    {
        DIContainer.SetModule<INamiMoveManager, NamiVer_1>();
    }
    public void ExchangeNamiVer_2()
    {
        DIContainer.SetModule<INamiMoveManager, NamiVer_2>();
        hero.SetupInterface();
    }
    public void ExchangeNamiVer_1()
    {
        DIContainer.SetModule<INamiMoveManager, NamiVer_1>();
        hero.SetupInterface();
    }
}
