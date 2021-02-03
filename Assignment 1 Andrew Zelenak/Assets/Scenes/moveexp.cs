using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveexp : MonoBehaviour
{
    public float speedf = 1.5f;
    public float jumpspeed = 1f;
    public KeyCode Forward;
    public KeyCode backwards;
    public KeyCode right;
    public KeyCode left;
    public KeyCode jump;
    public Rigidbody rb;
    public float amountjumps = 0f;
    public bool onground;
    public float numberofjumps = 2;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame 
    void Update()
    {
        // Here we will store the position that this object will have at the end of the frame
        Vector3 frameDestination;
        // we set the varible to be the current position of the object for now
        frameDestination = transform.position;



        if (Input.GetKey(Forward))
        {
            rb.AddForce(Vector3.right * speedf, ForceMode.Impulse);
        }

        { 

            if (Input.GetButtonDown("Jump"))
            {
                rb.AddForce(Vector3.up * jumpspeed, ForceMode.Impulse);
            }
        }
        

        if (Input.GetKey(backwards))
        {
            frameDestination.y = frameDestination.y - (speedf * Time.deltaTime);

        }

        if (Input.GetKey(right))
        {
            frameDestination.z = frameDestination.z + (speedf * Time.deltaTime);
        }

        if (Input.GetKey(left))
        {
            frameDestination.z = frameDestination.z - (speedf * Time.deltaTime);

            
        }

        
         
        this.transform.position = frameDestination;
    }

    
}
   