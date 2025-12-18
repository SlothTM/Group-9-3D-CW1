using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Dialogue_Trigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject trigger;
    public GameObject text;
    private Coroutine stopper;
    public bool inrange = false;

    // Update is called once per frame
    void Update()
    {
        if (inrange && Input.GetKeyDown(KeyCode.E))
        {
            text.SetActive(false);
            trigger.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inrange = true;
            text.SetActive(true);
            if (stopper != null)
            {
                StopCoroutine(stopper);
                stopper = null;
            }

        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (inrange)
        {
            stopper = StartCoroutine(exited());
        }
        text.SetActive(false);

    }

    private IEnumerator exited()
    {
        yield return new WaitForSeconds(3f);
        trigger.SetActive(false);
        inrange = false;
    }
}
