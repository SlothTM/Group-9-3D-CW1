using UnityEngine;

public class Char : MonoBehaviour
{
    public CharacterController controller;
    [SerializeField] private States game;
    public float speed = 100f;
    public float gravity = -9.81f;
    public bool paused = false;

    Vector3 velocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!game.pausedState)
        {
            float x = Input.GetAxis("Horizontal");  //Take input from keyboard for both axis
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;  //create a vector in the direction the camera is facing
            controller.Move(move * Time.deltaTime * speed); //actually move the player in the direction of the camera

            velocity.y += gravity * Time.deltaTime; //apply gravity to players y

            controller.Move(velocity * Time.deltaTime); //move the player downwards due to gravity

            if (controller.isGrounded)  //basic ground check inbuilt with character controller
            {
                velocity.y = 0; //reset y when grounded so they dont build up downwards speed
            }
        }
    }
}
