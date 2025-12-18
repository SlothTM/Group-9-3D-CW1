using UnityEngine;

public class AnimPlay : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            anim.Play("Walk", -1, 0f);
        }
        if (Input.GetKeyDown("2"))
        {
            anim.Play("Flip", -1, 0f);
        }
    }
}
