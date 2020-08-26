using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCamraBackColor : MonoBehaviour
{
    public Camera cam;
    private bool haveEnter = false;
    public Color colorCam;    
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
        if (other.GetComponentInParent<twoshpere>() != null && !haveEnter)
        {
            haveEnter = true;
            cam.backgroundColor = colorCam ;
        }
    }
}
