using UnityEngine;
using System.Collections;

public class DBFromPlayerPref : IDatabase
{
    private DataHero data;
    public DBFromPlayerPref()
    {
        Debug.Log("LoadPref");
        if (PlayerPrefs.GetInt("ConvertFromText", 0) == 0)
        {
            //PlayerPrefs.SetInt("ConvertFromText", 1);
            //data = SaveIO.LoadData("DataHero");
            DataHero data = new DataHero("Nami", 69, 0.01f);
            SaveData(data);
        }
        else
            LoadData();
    }
    public DataHero GetData()
    {
        return data;
    }

    public void LoadData()
    {
        data = JsonUtility.FromJson<DataHero>(PlayerPrefs.GetString("DataHero"));
    }

    public void SaveData(DataHero data)
    {
        this.data = data;
        PlayerPrefs.SetString("DataHero", JsonUtility.ToJson(data));
    }


}
