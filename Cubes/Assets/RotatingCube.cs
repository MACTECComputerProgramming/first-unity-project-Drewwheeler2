using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.;

public class RotatingCube : MonoBehaviour
{
    public Vector3 editRotation;
    public Keyboard keyboard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(editRotation);
        Debug.Log("update"); 
    }

    private void FixedUpdate()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

    }
}
