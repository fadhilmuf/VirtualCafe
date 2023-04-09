using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float run;
    float rotation = 50f;
    public static movement instance;
    public string areaTransition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed * run;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed * run;
        float y = Input.GetAxis("Jump") * Time.deltaTime * moveSpeed * run;
        transform.Translate(x,y,z);

        RotatePlayer();

        if(Input.GetKey(KeyCode.LeftShift))
        {
            run = 10f;
        }
        else
        {
            run = 1f;
        }

    }
    void RotatePlayer()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            ApplyRotation(-rotation);
        }
        if(Input.GetKey(KeyCode.E))
        {
            ApplyRotation(rotation);
        }
    }
    void ApplyRotation(float rotationThisFrame)
    {
        transform.Rotate(Vector3.down * rotationThisFrame * Time.deltaTime);
    }
}
