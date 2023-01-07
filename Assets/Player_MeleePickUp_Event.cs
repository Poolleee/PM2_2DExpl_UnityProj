using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_MeleePickUp_Event : MonoBehaviour
{
    public AK.Wwise.Event MeleePickup_Event;
    public void PlayMeleePickup()
    {
        MeleePickup_Event.Post(gameObject);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
