using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    [SerializeField]
    MyLevelData data;
    // Start is called before the first frame update
    void Start()
    {

        //  JsonTest.SaveMyLevel("Assets/level.txt");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            data = JsonTest.LoadMyLevel("Assets/Data/level.json");
        }
    }
}
