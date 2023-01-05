using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_HubDoor_Event : MonoBehaviour
{
    public AK.Wwise.Event HubDoor_Event;
    public void PlayHubDoor()
    {
        HubDoor_Event.Post(gameObject);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
