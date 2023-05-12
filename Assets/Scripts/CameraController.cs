using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public enum Camera
    {
        MAIN,
        HOOD
    };

    //Public Variables
    public GameObject player;
    public Camera selectedCamera;

    //Private Variables
    private Vector3 mainOffset = new(0, 5, -6);
    private Vector3 hoodOffset = new(0, 2.1f, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = player.transform.position + (selectedCamera == Camera.MAIN ? mainOffset : hoodOffset);

        if (selectedCamera == Camera.HOOD) transform.rotation = player.transform.rotation;
    }
}
