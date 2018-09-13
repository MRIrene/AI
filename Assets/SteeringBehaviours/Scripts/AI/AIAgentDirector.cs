using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SteeringBehaviours
{
    public class AIAgentDirector : MonoBehaviour
    {
        public AIAgent agent;
        public Transform placeHolderPoint;

        private void OnDrawGizmosSelected()
        {
            Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Draw a line from the start; where the ray starts from to
            // the end: where the ray is going
            Gizmos.color = Color.red;
            Gizmos.DrawLine(camRay.origin, camRay.origin + camRay.direction * 1000f);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Try to get seek component on agent
                Seek seek = agent.GetComponent<Seek>();
                // if seek if not null
                if (seek)
                {
                    Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(camRay, out hit, 1000f))
                    {
                        // update the transform's position
                        placeHolderPoint.position = hit.point;
                        //update seek's target 
                        seek.target = placeHolderPoint;
                    }
                }
            }
        }
    }
}