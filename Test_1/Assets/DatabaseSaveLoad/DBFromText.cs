using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DBFromText : IDatabase
{
    private DataHero data;

    public DBFromText()
    {
        Debug.Log("Load Text");
        LoadData();
    }
    public void LoadData()
    {
        data = SaveIO.LoadData("DataHero");
    }

    public void SaveData(DataHero data)
    {
        this.data = data;
        SaveIO.SaveData(this.data, "DataHero");
    }
    public DataHero GetData()
    {
        return data;
    }
}
