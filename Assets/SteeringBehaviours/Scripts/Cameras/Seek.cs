using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour {

    public Transform target;
    public float stoppingDistance;

    public override Vector3 GetForce()
    {
        //Get direction to target
        Vector3 direction = target.position - owner.transform.position;
        //Normalise direction (remove the magnitude part of vector)
        direction.Normalize();
        return direction * owner.maxSpeed; // return velocity (direction x speed)
    }

	
}
