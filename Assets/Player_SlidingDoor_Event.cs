using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_SlidingDoor_Event : MonoBehaviour
{
    public AK.Wwise.Event SlidingDoor_Event;
    public void PlaySlidingdoor()
    {
        SlidingDoor_Event.Post(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
