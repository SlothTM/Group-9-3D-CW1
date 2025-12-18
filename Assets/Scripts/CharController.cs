using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
	//PSEDO CODE: Declare and innicalise float variables for speed, maxspeed, acceleration, deceleration, rotation
	public float speed = 10.0f;
	public float maxspeed = 100.0f;
	public float acc = 5.0f;
	public float dec = 5.0f;
	public float rotation = 0.0f;
	// Start is called before the first frame update
	void Start()
    {

	}

    // Update is called once per frame
    void Update()
    {
		//PSEUDO CODE: Check for space key input. If not max speed, accelerate, else decelerate
		if(Input.GetKey("space"))
		{
			//acc
			if(speed < maxspeed){
				speed += acc;
				//speed = speed + acceleration

			}
			
		}
		else
		{
			//dec
			if(speed > 0)
			{
				speed -= dec;
			}
		}

		//PSEUDO CODE: Use the speed and transform to move the object forward
		//FUNCTION: Simplist transform with ACC, DEC, Speed (Space bar), and TDT
		transform.position += transform.forward * Time.deltaTime * speed;
		//PSEUDO CODE: Check for Left and Right Key inputs. Turn if left or right keys are pressed
		if ((Input.GetKey(KeyCode.LeftArrow)))
		{
			transform.Rotate(0, 1.0f, 0);
		}
		if ((Input.GetKey(KeyCode.RightArrow)))
		{
			transform.Rotate(0, -1.0f, 0);
		}
	
	}

}
