using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //Private variables
    private readonly float speed = 25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move Enemy forward
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }
}
