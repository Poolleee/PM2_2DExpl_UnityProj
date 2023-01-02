using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_AcidDive_Event : MonoBehaviour
{
    public AK.Wwise.Event AcidDive_Event;
    public void PlayAcidDive()
    {
        AcidDive_Event.Post(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
