using UnityEngine;

public class CameraSwithc : MonoBehaviour
{
    public GameObject[] platforms;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0f, 6.66f, -11.19f);
        foreach (GameObject platform in platforms)
        {
            platform.SetActive(false);
        }

        platforms[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (GameObject platform in platforms)
            {
                platform.SetActive(false);
            }

            transform.position = new Vector3(0f, 6.66f, -11.19f);
            platforms[0].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (GameObject platform in platforms)
            {
                platform.SetActive(false);
            }

            transform.position = new Vector3(11f, 6.66f, -11.19f);
            platforms[1].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            foreach (GameObject platform in platforms)
            {
                platform.SetActive(false);
            }

            transform.position = new Vector3(22f, 6.66f, -11.19f);
            platforms[2].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            foreach (GameObject platform in platforms)
            {
                platform.SetActive(false);
            }
            transform.position = new Vector3(33f, 6.66f, -11.19f);
            platforms[3].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            foreach (GameObject platform in platforms)
            {
                platform.SetActive(false);
            }
            transform.position = new Vector3(44f, 6.66f, -11.19f);
            platforms[4].SetActive(true);
        }


        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            foreach (GameObject platform in platforms)
            {
                platform.SetActive(false);
            }
            transform.position = new Vector3(55f, 6.66f, -11.19f);
            platforms[5].SetActive(true);
        }
    }
}
