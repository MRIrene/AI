// using System.Collections;
// using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///control + K + D to clear code
//ALT + SHIFT + UP or DOWN Arrows

public class CameraBounds : MonoBehaviour
{

    public Vector3 size = new Vector3(50f, 0f, 20f);

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, size);
    }


    // This function returns an adjusted vector3
    //<param name = "incomingPos"> the position coming in </param>

    public Vector3 GetAdjustedPosition(Vector3 incomingPos)
    {
        // Get bounds position
        Vector3 pos = transform.position;
        Vector3 halfSize = size * 0.5f;

        //if the incomingPos is outside the bounds of 
        if (incomingPos.x > pos.x + halfSize.x)
        {
            //cap it
            incomingPos.x = pos.x + halfSize.x;
        }


        // if the incomingPos is outside the bounds of x
        if (incomingPos.x < pos.x - halfSize.x)
        {
            incomingPos.x = pos.x - halfSize.x;
        }


        //if the incomingPos is outside the bounds of
        if (incomingPos.z > pos.z + halfSize.z)
        {
            //cap it
            incomingPos.z = pos.z + halfSize.z;
        }


        // if the incomingPos is outside the bounds of x
        if (incomingPos.z < pos.z - halfSize.z)
        {
            incomingPos.z = pos.z - halfSize.z;
        }


        return incomingPos;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
