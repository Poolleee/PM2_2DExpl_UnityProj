using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_StartStopPlatform_Event : MonoBehaviour
{
    public AK.Wwise.Event StartMovingPlatform_Event;
    public AK.Wwise.Event StopMovingPlatform_Event;
    public void PlayStartMovingPlatform()
    {
        StartMovingPlatform_Event.Post(gameObject);
    }

    public void PlayStopMovingPlatform()
    {
        StopMovingPlatform_Event.Post(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
