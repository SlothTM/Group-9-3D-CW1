using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BrickTriggerImplode : MonoBehaviour

{

    private GameObject brickArrayTag;
    // Use this for initialization

    void Start()

    {

        brickArrayTag = GameObject.FindGameObjectWithTag("BrickArrayTag");

    }


    public void OnMouseDown()

    {

        brickArrayTag.GetComponent<Animator>().Play("implode");


    }


}