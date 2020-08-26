using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAni : MonoBehaviour
{
    public Animator[] Obj;
    private bool haveEnter = false;
    void Start()
    {
        for (int i = 0; i < Obj.Length; i++)
        {
            Obj[i].enabled = false;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<twoshpere>() != null && !haveEnter)
        {
            haveEnter = true;
            for (int i = 0; i < Obj.Length; i++)
            {
                Obj[i].enabled = true;
            }
        }
    }
}