using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 30;

    void Update()
    {
        // Move Vehicle Foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
