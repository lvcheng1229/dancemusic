using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCameraFov : MonoBehaviour
{
    public Camera cam;
    public float fov;
    private bool haveEnter = false;
    public float needTime = 1.0f;
    private float timeUsed = 0f;
    private bool change = false;
    private float startFov;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(change)
        {
            timeUsed += Time.deltaTime;
            cam.fieldOfView += (fov - startFov) * Time.deltaTime / needTime;
        }
        if(change&&timeUsed>needTime)
        {
            change = false;
            timeUsed = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<twoshpere>() != null && !haveEnter)
        {
            haveEnter = true;
            change = true;
            startFov = cam.fieldOfView;
        }
    }
}
