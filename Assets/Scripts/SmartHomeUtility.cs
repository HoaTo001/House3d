using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartHomeUtility : MonoBehaviour
{
    public Camera house_camera;
    public Camera kitchen_camera;
    public Camera bathroom_camera;
    public Camera room_camera;
    // Start is called before the first frame update
    void Start()
    {
        house_camera.GetComponent<Camera>().enabled = true;
        kitchen_camera.GetComponent<Camera>().enabled = false;
        bathroom_camera.GetComponent<Camera>().enabled = false;
        room_camera.GetComponent<Camera>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            house_camera.enabled = true;
            kitchen_camera.enabled = false;
            bathroom_camera.enabled = false;
            room_camera.enabled = false;
        }
        else if (Input.GetKeyDown("2"))
        {
            house_camera.enabled = false;
            kitchen_camera.enabled = true;
            bathroom_camera.enabled = false;
            room_camera.enabled = false;
        }
        else if (Input.GetKeyDown("3"))
        {
            house_camera.enabled = false;
            kitchen_camera.enabled = false;
            bathroom_camera.enabled = true;
            room_camera.enabled = false;
        }
        else if (Input.GetKeyDown("4"))
        {
            house_camera.enabled = false;
            kitchen_camera.enabled = false;
            bathroom_camera.enabled = false;
            room_camera.enabled = true;
        }
    }
}
