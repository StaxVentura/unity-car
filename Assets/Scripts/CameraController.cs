using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Public Variables
    public GameObject player;
    public bool isMainCamera = true;

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

        transform.position = player.transform.position + (isMainCamera ? mainOffset : hoodOffset);

        if (!isMainCamera) transform.rotation = player.transform.rotation;
    }
}
