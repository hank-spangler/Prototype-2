using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public string axisName = "Set Input Axis";
    public float speed = 10.0f;
    public float xBound = 12.0f;
    public float zBound = 12.0f;
    public string AxisName = "Set Input Axis";

    // Start is called before the first frame update
    void Start () 
    {

    }

    private float horizontalInput;
    private float verticalInput;

    // Update is called once per frame
    void Update () 
    {
        // Player movement.
        horizontalInput = Input.GetAxis (axisName);
        transform.Translate (horizontalInput * speed * Time.deltaTime * Vector3.right);
        
        verticalInput = Input.GetAxis (AxisName);
        transform.Translate (verticalInput * speed * Time.deltaTime * Vector3.forward);
        
        // X axis bounds
        if (transform.position.x < -xBound) 
        {
            transform.position = new Vector3 (-xBound, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xBound) 
        {
            transform.position = new Vector3 (xBound, transform.position.y, transform.position.z);
        }
        
        // Z axis bounds
        if (transform.position.z < -zBound) 
        {
            transform.position = new Vector3 (-zBound, transform.position.y, transform.position.x);
        }
        if (transform.position.z > zBound) 
        {
            transform.position = new Vector3 (zBound, transform.position.y, transform.position.x);
        }
    }
}