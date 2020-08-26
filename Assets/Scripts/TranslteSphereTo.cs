using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslteSphereTo : MonoBehaviour
{
    public GameObject firRoad, secRoad;
    private bool haveEnter = false;
    private bool change = false;
    twoshpere ts;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void LateUpdate()
    {
        if(change)
        {
            ts.sphereCenter.transform.position = secRoad.transform.position;
            ts.sphereCenter.transform.Translate(new Vector3(0, 0.7f, 0), Space.World);
            ts.sphereCenter.transform.rotation = secRoad.transform.rotation;

            ts.sphereRotate.transform.position = firRoad.transform.position;
            ts.sphereRotate.transform.Translate(new Vector3(0, 0.7f, 0),Space.World);
            ts.sphereRotate.transform.rotation = firRoad.transform.rotation;
            change = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<twoshpere>() != null && !haveEnter)
        {
            ts = other.GetComponentInParent<twoshpere>();
            haveEnter = true;
            change = true;
        }
    }
}
