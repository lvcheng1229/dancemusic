using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerScript : MonoBehaviour
{
    public Material matt;
    
    [HideInInspector] public twoshpere ts;

    private bool change = false;
    private bool haveEnter = false;
    private float timeUsed = 0f;
    private Material matTemp;
    private float halfCycle;
    // Start is called before the first frame update
    void Start()
    {
        ts = GameObject.FindObjectOfType<twoshpere>();
        halfCycle = ts.oneCycle * 0.5f;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        if(change)
        {
            timeUsed += Time.deltaTime;          
        }
        if(change && timeUsed > halfCycle)
        {
            change = false;
            this.GetComponent<Renderer>().sharedMaterial = matTemp;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<twoshpere>() != null&&!haveEnter)
        {
            change = true;
            haveEnter = true;
            matTemp = this.GetComponent<Renderer>().sharedMaterial;
            this.GetComponent<Renderer>().material = matt;     
        }
    }
}
