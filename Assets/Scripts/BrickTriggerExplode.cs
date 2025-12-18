using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BrickTriggerExplode : MonoBehaviour

{
    public GameObject brickArray;


    private void Update()
    {
        
    }

    void OnMouseDown()
    {
        brickArray.GetComponent<Animator>().Play("explode");
    }


}