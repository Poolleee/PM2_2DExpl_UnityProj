using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShieldAnimationsEvents : MonoBehaviour
{
    public AK.Wwise.Event ShieldOn_Event;
    public AK.Wwise.Event ShieldOff_Event;
    public AK.Wwise.Event ShieldHit_Event;
    public void PlayShieldOn()
    {
        ShieldOn_Event.Post(gameObject);
    }

    public void PlayShieldOff()
    {
        ShieldOff_Event.Post(gameObject);
    }

    public void PlayShieldHit()
    {
        ShieldHit_Event.Post(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
