using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_AcidBall_Event : MonoBehaviour
{
    public AK.Wwise.Event AcidBall_Event;
    public AK.Wwise.Event AcidBall_Hit_Event;
   public  void PlayAcidBall()
    {
        AcidBall_Event.Post(gameObject);
    }

    public void PlayAcidBallHit()
    {
        AcidBall_Hit_Event.Post(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
