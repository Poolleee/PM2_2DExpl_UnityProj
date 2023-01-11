using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Ambient_Event : MonoBehaviour
{
   
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
