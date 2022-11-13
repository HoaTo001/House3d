using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SmartHomeUtility : MonoBehaviour
{
    public Camera house_camera;
    public Camera kitchen_camera;
    public Camera bathroom_camera;
    public Camera room_camera;
    public Light light_1;
    public Light light_2;
    public ParticleSystem sink_water;
    public ParticleSystem shower_water;
    public ParticleSystem stove_1;
    public ParticleSystem stove_2;
    public ParticleSystem gas_leakage;

    // Start is called before the first frame update
    void Start()
    {
        house_camera.GetComponent<Camera>().enabled = true;
        kitchen_camera.GetComponent<Camera>().enabled = false;
        bathroom_camera.GetComponent<Camera>().enabled = false;
        room_camera.GetComponent<Camera>().enabled = false;
        light_1.GetComponent<Light>().enabled = false;
        light_2.GetComponent<Light>().enabled = false;
        sink_water.GetComponent<ParticleSystem>().Stop();
        shower_water.GetComponent<ParticleSystem>().Stop();
        stove_1.GetComponent<ParticleSystem>().Stop();
        stove_2.GetComponent<ParticleSystem>().Stop();
        gas_leakage.GetComponent<ParticleSystem>().Stop();
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

        if(Input.GetKeyDown("space"))
        {
            if (sink_water.isStopped)
            {
                sink_water.Play();
            }
            else if (sink_water.isPlaying)
            {
                sink_water.Stop();
            }

            if (shower_water.isStopped)
            {
                shower_water.Play();
            }
            else if (shower_water.isPlaying)
            {
                shower_water.Stop();
            }
        }
    }
}
