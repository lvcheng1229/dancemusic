using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeTrigger : MonoBehaviour {
	public Camera CameraShake;
	public float seconds  = 0.2f;//震动持续秒数
	public float quake = 0.4f;//震动系数

    private bool haveEnter = false;
    private bool change = false;
    private float timeUsed=0f;
    private Vector3 camPOS;  //camera的起始位置
    private Vector3 deltaPos = Vector3.zero;
    // Use this for initialization
    void Start()
    {
        camPOS = CameraShake.transform.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        if (change)
        {
            timeUsed += Time.deltaTime;
            CameraShake.transform.localPosition -= deltaPos;
            deltaPos = Random.insideUnitSphere * (quake / 5);
            CameraShake.transform.localPosition += deltaPos;
        }

        if (change&&timeUsed>seconds)
        {
            change = false;
            timeUsed = 0f;
        }
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other) {
        if (other.GetComponentInParent<twoshpere>() != null && !haveEnter)
        {
            haveEnter = true;
            change = true;
            print("aaaaa");
        }
    }
}