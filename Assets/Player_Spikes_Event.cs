using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Spikes_Event : MonoBehaviour
{
    public AK.Wwise.Event CrystalHit_Event;
    public void PlayCrystalHit()
    {
        CrystalHit_Event.Post(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
