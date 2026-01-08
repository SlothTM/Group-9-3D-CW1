using UnityEngine;

public class States : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool pausedState = false;    
    public GameObject pausescreen;
    public GameObject ptext;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Escape)) && !pausedState)
        {
            pausedState = true;
            Time.timeScale = 0f;
        }

        else if ((Input.GetKeyDown(KeyCode.Escape)) && pausedState)
        {
            pausedState = false;
            Time.timeScale = 1f;
        }

        if (pausedState)
        {
            pausescreen.SetActive(true);
            ptext.SetActive(true);
        }
        else
        {
            pausescreen.SetActive(false);
            ptext.SetActive(false);
        }
    }
}
