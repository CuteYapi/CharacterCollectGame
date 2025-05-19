using UnityEngine;

public class Manager : MonoBehaviour
{
    private void Start()
    {
        SetDataManager();
        SetPoolManager();
    }

    public static DataManager Data { get; private set; }

    private void SetDataManager()
    {
        Data = GetComponentInChildren<DataManager>();
        Data.Initialize();
    }

    public static PoolManager Pool { get; private set; }

    private void SetPoolManager()
    {
        Pool = GetComponentInChildren<PoolManager>();
        Pool.Initialize();
    }
}
