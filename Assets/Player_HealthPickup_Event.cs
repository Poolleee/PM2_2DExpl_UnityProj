using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_HealthPickup_Event : MonoBehaviour
{
    public AK.Wwise.Event HealthPickup_Event;
    public void PlayHealthPickup()
    {
        HealthPickup_Event.Post(gameObject);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
