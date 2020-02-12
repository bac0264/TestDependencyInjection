using UnityEngine;
using System.Collections;

public interface IDatabase
{
    void SaveData(DataHero data);

    void LoadData();

    DataHero GetData();
}
