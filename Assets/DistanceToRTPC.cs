using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceToRTPC : MonoBehaviour
{
    public GameObject Object;
    public GameObject Player;
   
    void Update()
    {
        Vector2 Pos1 = Object.transform.position;
        Vector2 Pos2 = Player.transform.position;
        float x1 = Pos1.x, x2 = Pos2.x, y1 = Pos1.y, y2 = Pos2.y;
        // Distance between X coordinates
        float xDif = Mathf.Abs(Mathf.Max(x1, x2) - Mathf.Min(x1, x2));
        // Distance between Y coordinates
        float yDif = Mathf.Abs(Mathf.Max(y1, y2) - Mathf.Min(y1, y2));
        // Pythagorean theorem
        float finalDistance = Mathf.Sqrt(xDif * xDif + yDif * yDif);
        Debug.Log("Distance Between Object1 And Object2 Is " + finalDistance);

        AkSoundEngine.SetRTPCValue("Cave_Depth", finalDistance);
    }
}
