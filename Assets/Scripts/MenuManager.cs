using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public string PlayerName;
    public int Score;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);

        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }



}
