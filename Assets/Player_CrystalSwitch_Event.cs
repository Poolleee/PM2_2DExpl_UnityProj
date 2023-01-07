using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_CrystalSwitch_Event : MonoBehaviour
{
    public AK.Wwise.Event CrystalSwitch_Event;
    public void PlayCrystalSwitch()
    {
        CrystalSwitch_Event.Post(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
