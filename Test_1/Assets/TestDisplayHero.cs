using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestDisplayHero : MonoBehaviour
{
    private void Awake()
    {
        Akali akali = new Akali();
        Nami nami = new Nami();
        Hero hero = new Hero();
        List<Hero> heros = new List<Hero>();
        heros.Add(akali);
        heros.Add(nami);
        heros.Add(hero);

        DisplayHero(heros);
    }
    public void DisplayHero(List<Hero> heros)
    {
        for (int i = 0; i < heros.Count; i++) {
            heros[i].HeroDisplay();
            heros[i].SetupInterface();
        }
    }
}
