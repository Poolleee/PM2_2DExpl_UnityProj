using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_PickKey_Event : MonoBehaviour
{
    public AK.Wwise.Event PickKey_Event;
    public void PlayPickKey()
    {
        PickKey_Event.Post(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
