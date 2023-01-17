using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBeamEffectEvent : MonoBehaviour
{
    public AK.Wwise.Event BeamLaser_Event;
    void PlayBeamLaser()
    {
        BeamLaser_Event.Post(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
