using UnityEngine;

public class Manager : MonoBehaviour
{
    private void Start()
    {
        SetDataManager();
        SetPoolManager();

#if LOG
        SetLogManager();
#endif
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


#if LOG
    public static LogManager Log { get; private set; }
    private void SetLogManager()
    {
        Log = GetComponentInChildren<LogManager>();
        Log.Initialize();
    }
#endif
}
