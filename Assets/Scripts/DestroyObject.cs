using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public int destroyPointer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<twoshpere>() != null)
        {
            if(other.GetComponentInParent<twoshpere>().pointer==(destroyPointer-1))
                Destroy(this.gameObject);
        }
    }
}
