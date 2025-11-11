using System;
using UnityEngine;

public class AnimPlayer : MonoBehaviour
{
    public int currentfig = 0;
    public GameObject[] figs; // Array to hold references to animation GameObjects
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (GameObject fig in figs)
        {
            fig.SetActive(false);
        }

        figs[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        figs[currentfig].SetActive(true);

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            figs[currentfig].SetActive(false);
            if (currentfig == figs.Length - 1)
            {
                currentfig = 0;
            }
            else
            {
                currentfig += 1;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            figs[currentfig].SetActive(false);
            if (currentfig == 0)
            {
                currentfig = figs.Length;
            }
            else
            {
                currentfig -= 1;
            }
        }
    }


}
