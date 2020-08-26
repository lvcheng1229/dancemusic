using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPosToNewPos : MonoBehaviour
{
    public Vector3 NewPos = Vector3.zero;
    public float needtime = 1.0f;
    public GameObject ObjectMove;

    private Vector3 StartPos;
    private bool haveEnter = false;
    private bool change = false;
    private float timeUsed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = ObjectMove.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(change)
        {
            timeUsed += Time.deltaTime;
            ObjectMove.transform.Translate((NewPos - StartPos) * Time.deltaTime / needtime, Space.World);
        }
        if(change&&timeUsed>needtime)
        {
            change = false;
            timeUsed = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<twoshpere>() != null&&!haveEnter)
        {
            haveEnter = true;
            change = true;
        }
    }
}
