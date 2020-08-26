using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twoshpere : MonoBehaviour
{
    public Camera BitCamera;
    public GameObject StartRoad;
    public GameObject Sphere1, Sphere2;
    public float strenth = 20f;
    public int startBit;
    public int []indexTranslate;
    public Vector3[] translatePosCenter;
    public Vector3[] translatePosRotated;
    public int []indexChangeBit;
    public int[] changeBit;
    public int[] indexChangeDirection;
    public string roadString =
    "6666666666";
    public bool checkMusic = false;
        
       
    [HideInInspector] public bool canRotate = false;  
    [HideInInspector] public GameObject sphereCenter, sphereRotate, sphereTemp;
    [HideInInspector] public float oneCycle = 60.0f/150.0f*2.0f;
    [HideInInspector] public Collider colliderLast;
    [HideInInspector] public int pointer = 0;

    private float nextTime = 0.0f;
    private bool autoCom = true;
    private float timeUsed = 0.0f;
    private int direction = 1;
    private bool camBit = false;
    private float timeBit = 0f;
    private float seconds = 0.1f;

    private int ichangeDirection=0;
    private int ichangeSpeed=0;
    private int ichangePos=0;

    private float stop = 1f;
    // Start is called before the first frame update
    void Start()
    {
        oneCycle = 60f / startBit * 2f;
        colliderLast = StartRoad.GetComponent<Collider>();
        sphereCenter = Sphere1;
        sphereRotate = Sphere2;
        switch(roadString[1])
        {
            case '1': nextTime = oneCycle * 7f / 8f; break;
            case '2': nextTime = oneCycle * 6f / 8f; break;
            case '3': nextTime = oneCycle * 5f / 8f; break;
            case '6': nextTime = oneCycle * 4f / 8f; break;
            case '9': nextTime = oneCycle * 3f / 8f; break;
            case '8': nextTime = oneCycle * 2f / 8f; break;
            case '7': nextTime = oneCycle * 1f / 8f; break;
        }

        if (indexChangeBit.Length == 0)
            ichangeSpeed = -1;
        if (indexChangeDirection.Length == 0)
            ichangeDirection = -1;
        if (indexTranslate.Length == 0)
            ichangePos = -1;
    }
    
    // Update is called once per frame
    void Update()
    {
        
        rotateSphere(stop*180.0f * Time.deltaTime / (oneCycle*0.5f)*direction);
       if(Mathf.Abs(timeUsed-nextTime)<0.015&&stop==1.0f)
        {
            
            if(checkMusic)
            {
                this.GetComponent<AudioSource>().time = this.GetComponent<AudioSource>().time - timeUsed + nextTime;
            }
            sphereRotate.transform.RotateAround(sphereCenter.transform.position, sphereCenter.transform.up, direction*(nextTime - timeUsed) *(nextTime/oneCycle*360.0f) / nextTime);

            camBit = true;
            pointer++;

            if(ichangeDirection!=-1&&indexChangeDirection[ichangeDirection]==pointer)
            {
                direction = -direction;
                ichangeDirection++;
                if(ichangeDirection==indexChangeDirection.Length)
                {
                    ichangeDirection = -1;
                }
            }

            if(ichangeSpeed!=-1&&indexChangeBit[ichangeSpeed]==pointer)
            {
                oneCycle = 60f / changeBit[ichangeSpeed] * 2f;
                ichangeSpeed++;
                if(ichangeSpeed==indexChangeBit.Length)
                {
                    ichangeSpeed = -1;
                }
            }

            switch (roadString[pointer])
            {
                case '1': nextTime = oneCycle * 7f / 8f; break;
                case '2': nextTime = oneCycle * 6f / 8f; break;
                case '3': nextTime = oneCycle * 5f / 8f; break;
                case '6': nextTime = oneCycle * 4f / 8f; break;
                case '9': nextTime = oneCycle * 3f / 8f; break;
                case '8': nextTime = oneCycle * 2f / 8f; break;
                case '7': nextTime = oneCycle * 1f / 8f; break;
            }

            if(autoCom)
            {
                sphereTemp = sphereCenter;
                sphereCenter = sphereRotate;
                sphereRotate = sphereTemp;
            }

            if(ichangePos!=-1&&indexTranslate[ichangePos]==pointer)
            {
                sphereCenter.transform.position = translatePosCenter[ichangePos];
                sphereRotate.transform.position = translatePosRotated[ichangePos];
                ichangePos++;
                if(ichangePos==indexTranslate.Length)
                {
                    ichangePos = -1;
                }
            }

            timeUsed = 0.0f;
        }

        if (Input.GetMouseButton(0))
        {
            this.GetComponent<AudioSource>().Play();
            canRotate = true;          
        }

        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            stop = 1 - stop;
        }

        if (camBit)
        {
            if (timeBit < seconds * 0.5f)
            {
                BitCamera.fieldOfView -= strenth * Time.deltaTime;
            }
            else
            {
                BitCamera.fieldOfView += strenth * Time.deltaTime;
            }
            timeBit += Time.deltaTime;
        }

        if (camBit && timeBit > seconds)
        {
            timeBit = 0.0f;
            camBit = false;
        }
    }
    
    public void rotateSphere(float angle)
    {
        if(canRotate== true)
        {
            timeUsed += Time.deltaTime;
            sphereRotate.transform.RotateAround(sphereCenter.transform.position,new Vector3(0,1,0), angle);
        }

    }

    public void GameOver()
    {
        print("GameOver");
    }
}
