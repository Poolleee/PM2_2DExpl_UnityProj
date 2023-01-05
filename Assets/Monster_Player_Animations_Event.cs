using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Player_Animations_Event : MonoBehaviour
{
    public AK.Wwise.Event Monster_Footstep_Event;
    public AK.Wwise.Event Monster_Run_Event;
    public AK.Wwise.Event Monster_Bite_Event;
    public AK.Wwise.Event Monster_Burp_Event;
    public AK.Wwise.Event Monster_Hit_Event;
    public void PlayMonsterFootstep()
    {
        Monster_Footstep_Event.Post(gameObject);
    }

    public void PlayMonsterRun()
    {
        Monster_Run_Event.Post(gameObject);
    }

    public void PlayMonsterBite()
    {
        Monster_Bite_Event.Post(gameObject);
    }

    public void PlayMonsterHit()
    {
        Monster_Hit_Event.Post(gameObject);
    }

    public void PlayMonsterBurp()
    {
        Monster_Burp_Event.Post(gameObject,  (uint)AkCallbackType.AK_EndOfEvent, AcidBallCallback );
    }

   
    void AcidBallCallback(object in_cookie, AkCallbackType in_type, object in_info )
    {
        Debug.Log("lollobarcollomanonmollo");
    }
}
