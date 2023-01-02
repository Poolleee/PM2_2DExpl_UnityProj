using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColumnEvents : MonoBehaviour
{

    public AK.Wwise.Event ColumnDestruction_Event;
    public AK.Wwise.Event ColumnHit_Event;
   
   public void PlayColumnDestruction()
    {
        ColumnDestruction_Event.Post(gameObject);
    }

    public void PlayColumnHit()
    {
        ColumnHit_Event.Post(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
