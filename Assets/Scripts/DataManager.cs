using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static Vector3 playerCurrentPos;
    public static string scene;

    static DataManager instance = null;
    public static DataManager Instance
    {
        get
        {
            if (instance == null) instance = new DataManager();
            return instance;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
