using UnityEngine;
using System.Collections;

public class TestDatabase : MonoBehaviour
{
    public Hero hero;
    public void Awake()
    {
        DIContainer.SetModule<IDatabase, DBFromPlayerPref>();
    }
    private void Start()
    {
        IDatabase database = DIContainer.GetModule<IDatabase>();
        hero.BASE = database.GetData();
    }
    public void DataFromText()
    {
        DIContainer.SetModule<IDatabase, DBFromText>();
        IDatabase database = DIContainer.GetModule<IDatabase>();
        hero.BASE = database.GetData();
    }
    public void DataFromPlayerPref()
    {
        DIContainer.SetModule<IDatabase, DBFromPlayerPref>();
        IDatabase database = DIContainer.GetModule<IDatabase>();
        hero.BASE = database.GetData();
    }
}
