// Returns a ray going from camera through a screen point.
// Resulting ray is in world space, starting on the near plane of the camera and going through position's (x,y) pixel coordinates on the screen (position.z is ignored).
// Screenspace is defined in pixels. The bottom-left of the screen is (0,0); the right-top is (pixelWidth -1,pixelHeight -1).

using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        }
        Debug.DrawRay(lastRay.origin, lastRay.direction * 100);
    }
}
