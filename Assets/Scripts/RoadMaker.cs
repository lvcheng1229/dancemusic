using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMaker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject startRoad;
    public GameObject insta1, insta2, insta3, insta6,insta7,insta8,insta9;

    private GameObject LastRoad;
    private GameObject road;
    void Start()
    {
        LastRoad = startRoad;
    }

    GameObject objMove(GameObject gobj,Vector3 t1,float r1,Vector3 t2,float r2,float r3)
    {
        GameObject roadd = Instantiate(gobj);
        roadd.transform.rotation = Quaternion.Euler(new Vector3(0, r1, 0));
        roadd.transform.position = t1;
        roadd.transform.localScale = new Vector3(1, 1, 1);

        roadd.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), r3);

        roadd.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), r2);
        roadd.transform.Translate(t2, Space.World);

        return roadd;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            switch (LastRoad.tag)
            {
                case "Road6":
                    road = objMove(insta1,
                        new Vector3(1.12f, 0, 0.05f), 135,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road2":
                    road = objMove(insta1,
                        new Vector3(1.12f, 0, 0.05f), 135,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road8":
                    road = objMove(insta1,
                        new Vector3(1.12f, 0, 0.05f), 135,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 90);
                    break;
                case "Road3":
                    road = objMove(insta1,
                        new Vector3(1.12f, 0, 0.05f), 135,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road9":
                    road = objMove(insta1,
                        new Vector3(1.12f, 0, 0.05f), 135,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 135);
                    break;
                case "Road1":
                    road = objMove(insta1,
                        new Vector3(1.24f, 0, 0.0f), 135,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road7":
                    road = objMove(insta1,
                        new Vector3(1.24f, 0, 0.0f), 135,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 45);
                    break;
            }
            LastRoad = road;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            switch (LastRoad.tag)
            {
                case "Road6":
                    road = objMove(insta2,
                        new Vector3(1f, 0, 0f), 90,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road2":
                    road = objMove(insta2,
                        new Vector3(1f, 0, 0f), 90,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road8":
                    road = objMove(insta2,
                        new Vector3(1f, 0, 0f), 90,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 90);
                    break;
                case "Road3":
                    road = objMove(insta2,
                        new Vector3(1f, 0, 0f), 90,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road9":
                    road = objMove(insta2,
                        new Vector3(1f, 0, 0f), 90,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 135);
                    break;
                case "Road1":
                    road = objMove(insta2,
                        new Vector3(1.12f, 0, -0.05f), 90,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road7":
                    road = objMove(insta2,
                        new Vector3(1.12f, 0, 0.05f), 90,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 45);
                    break;
            }
            LastRoad = road;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            switch (LastRoad.tag)
            {
                case "Road6":
                    road = objMove(insta3,
                        new Vector3(1f, 0, 0f), 45,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road2":
                    road = objMove(insta3,
                        new Vector3(1f, 0, 0f), 45,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road8":
                    road = objMove(insta3,
                        new Vector3(1f, 0, 0f), 45,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 90);
                    break;
                case "Road3":
                    road = objMove(insta3,
                        new Vector3(1f, 0, 0f), 45,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road9":
                    road = objMove(insta3,
                        new Vector3(1f, 0, 0f), 45,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 135);
                    break;
                case "Road1":
                    road = objMove(insta3,
                        new Vector3(1.12f, 0, -0.05f), 45,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road7":
                    road = objMove(insta3,
                        new Vector3(1.12f, 0, 0.05f), 45,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 45);
                    break;
            }
            LastRoad = road;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            switch (LastRoad.tag)
            {
                case "Road6":
                    road = objMove(insta6,
                        new Vector3(1f, 0, 0f), 0,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road2":
                    road = objMove(insta6,
                        new Vector3(1f, 0, 0f), 0,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road8":
                    road = objMove(insta6,
                        new Vector3(1f, 0, 0f), 0,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 90);
                    break;
                case "Road3":
                    road = objMove(insta6,
                        new Vector3(1f, 0, 0f), 0,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road9":
                    road = objMove(insta6,
                        new Vector3(1f, 0, 0f), 0,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 135);
                    break;
                case "Road1":
                    road = objMove(insta6,
                        new Vector3(1.12f, 0, -0.05f), 0,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road7":
                    road = objMove(insta6,
                        new Vector3(1.12f, 0, 0.05f), 0,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 45);
                    break;
            }
            LastRoad = road;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            switch (LastRoad.tag)
            {
                case "Road6":
                    road = objMove(insta7,
                        new Vector3(1.12f, 0, -0.05f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road2":
                    road = objMove(insta7,
                        new Vector3(1.12f, 0, -0.05f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road8":
                    road = objMove(insta7,
                        new Vector3(1.12f, 0, -0.05f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 90);
                    break;
                case "Road3":
                    road = objMove(insta7,
                        new Vector3(1.12f, 0, -0.05f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road9":
                    road = objMove(insta7,
                        new Vector3(1.12f, 0, -0.05f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 135);
                    break;
                case "Road1":
                    road = objMove(insta7,
                        new Vector3(1.24f, 0, 0f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road7":
                    road = objMove(insta7,
                        new Vector3(1.24f, 0, 0f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 45);
                    break;
            }
            LastRoad = road;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            switch (LastRoad.tag)
            {
                case "Road6":
                    road = objMove(insta8,
                        new Vector3(1f, 0, 0f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road2":
                    road = objMove(insta8,
                        new Vector3(1f, 0, 0f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road8":
                    road = objMove(insta8,
                        new Vector3(1f, 0, 0f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 90);
                    break;
                case "Road3":
                    road = objMove(insta8,
                        new Vector3(1f, 0, 0f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road9":
                    road = objMove(insta8,
                        new Vector3(1f, 0, 0f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 135);
                    break;
                case "Road1":
                    road = objMove(insta8,
                        new Vector3(1.12f, 0, -0.05f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road7":
                    road = objMove(insta8,
                        new Vector3(1.12f, 0, 0.05f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 45);
                    break;
            }
            LastRoad = road;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            switch (LastRoad.tag)
            {
                case "Road6":
                    road = objMove(insta9,
                        new Vector3(1f, 0, 0f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road2":
                    road = objMove(insta9,
                        new Vector3(1f, 0, 0f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road8":
                    road = objMove(insta9,
                        new Vector3(1f, 0, 0f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 90);
                    break;
                case "Road3":
                    road = objMove(insta9,
                        new Vector3(1f, 0, 0f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road9":
                    road = objMove(insta9,
                        new Vector3(1f, 0, 0f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 135);
                    break;
                case "Road1":
                    road = objMove(insta9,
                        new Vector3(1.12f, 0, -0.05f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 0);
                    break;
                case "Road7":
                    road = objMove(insta9,
                        new Vector3(1.12f, 0, 0.05f), 180,
                        LastRoad.transform.position, LastRoad.transform.rotation.eulerAngles.y, 45);
                    break;
            }
            LastRoad = road;
        }
    }
}
