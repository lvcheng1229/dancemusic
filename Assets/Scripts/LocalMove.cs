using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalMove : MonoBehaviour
{
    public Vector3 Move = Vector3.zero;
    public float needtime = 1.0f;
    public GameObject []ObjectMove;

    private bool haveEnter = false;
    private bool change = false;
    private float timeUsed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (change)
        {
            timeUsed += Time.deltaTime;
            for(int i=0;i<ObjectMove.Length;i++)
            {
                ObjectMove[i].transform.Translate(Move * Time.deltaTime / needtime,Space.World);
            }         
        }
        if (change && timeUsed > needtime)
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
        }
    }
}
