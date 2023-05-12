using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Public Variables
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    // Private variables
    private float speed = 25;
    private float turnSpeed = 60;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update()
    {

        // Player Inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move Car forward and backward
        transform.Translate(speed * Time.deltaTime * verticalInput * Vector3.forward);

        // Turn Car left and right
        transform.Rotate(Vector3.up, Time.deltaTime * verticalInput * horizontalInput * turnSpeed);

        // Reset scene after falling down
        if (gameObject.transform.position.y <= -30 || gameObject.transform.position.z > 350 )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


        // Camera
        // Add new Camera option
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}