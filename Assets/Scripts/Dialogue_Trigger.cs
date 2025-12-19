using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Dialogue_Trigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject dia;
    [SerializeField] private States game;
    public GameObject text;
    private Coroutine stopper;
    public bool inrange = false;
    public GameObject Dialoguebox;

    // Update is called once per frame
    void Update()
    {
        if (inrange && Input.GetKeyDown(KeyCode.E)) //press E to interact
        {
            game.pausedState = true; //pause the game
            Dialoguebox.SetActive(true);
            dia.SetActive(true); //start dialogue
            text.SetActive(false);

        }

        if (game.pausedState && Input.GetKeyDown(KeyCode.Escape)) //press escape to exit dialogue and unpauses
        {
            Dialoguebox.SetActive(false);
            dia.SetActive(false); //stop dialogue instantly
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inrange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            inrange = false;
            text.SetActive(false);
            stopper = StartCoroutine(exited());
        }
    }


    private IEnumerator exited()
    {
        yield return new WaitForSeconds(1f); //wait a second before exiting dialogue
        Dialoguebox.SetActive(false);
        dia.SetActive(false);
        game.pausedState = false;
        inrange = false;
    }
}
