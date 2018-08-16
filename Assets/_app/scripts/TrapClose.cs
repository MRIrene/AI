using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapClose : MonoBehaviour
{
    public Animator anim;
    
    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("IsOpened", false);
    }
}
