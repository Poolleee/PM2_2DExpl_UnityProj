using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_AcidDive_Event : MonoBehaviour
{
    public AK.Wwise.Event PlayerAcidDive_Event;
    public AK.Wwise.Event ObjectAcidDive_Event;
    public void PlayPlayerAcidDive()
    {
        PlayerAcidDive_Event.Post(gameObject);
    }

    public void PlayObjectAcidDive()
    {
        ObjectAcidDive_Event.Post(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
