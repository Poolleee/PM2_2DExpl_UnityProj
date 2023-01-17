using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectileEvent : MonoBehaviour
{
    public AK.Wwise.Event BeamProjectileHit_Event;
   public void PlayBeamProjectileHit()
    {
        BeamProjectileHit_Event.Post(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
