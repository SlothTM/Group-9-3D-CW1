using UnityEngine;

public class RigidMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float speed = 0f;
    public float maxSpeed = 100f;
    public float acceleration = 10f;
    public float rotation;

    public Rigidbody rb;  
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey("space"))
        {
           if(speed < maxSpeed)
            {
                speed += acceleration;
            }

        }


        else
        {
            if (speed > 0)
            {
                speed -= acceleration;
            }
        }

        transform.position += transform.forward * speed * Time.deltaTime;

        if(Input.GetKey("a"))
        {
            transform.Rotate(0, -0.5f, 0);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 0.5f, 0);
        }
    }
}
