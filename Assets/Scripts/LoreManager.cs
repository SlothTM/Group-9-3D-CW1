using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class LoreManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static LoreManager instance;

    public TextMeshProUGUI text;
    [TextArea(3, 10)]  //text box size in ediror easier to type
    public string[] dialogue;
    public float textSpeed;
    [SerializeField] private States game;
    public float timetowait = 2.0f;

    public int index; //current line

    // Start is called before the first frame update
    void Start()
    {
        index = 0; //makes sure it starts at 0

    }
    private void Update()
    {
        if (text.text == dialogue[index]) //once text finishes move onto next
        {
            StartCoroutine(next());
        }
    }
    // Update is called once per frame
    void Awake()
    {
        instance = this;

    }

    private void OnEnable()
    {
        StartDialogue(); //Once enabled start text immediately
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TexttoWrite()); //resets and starts to type
    }

    IEnumerator TexttoWrite()
    {
        foreach (char c in dialogue[index].ToCharArray()) //for every character in dialogue add it to the array to be printed
        {
            text.text += c; // one char at a time
            yield return new WaitForSeconds(textSpeed); //pauses for small time inbetween each char so its slowly written rather than all at once
        }

    }

    IEnumerator next()
    {

        if (index < dialogue.Length - 1)
        {
            index++;
            yield return new WaitForSeconds(2f);
            text.text = string.Empty;  //empty the Screen so next dialogue can start
            StartCoroutine(TexttoWrite());  //write the next text
        }
        else
        {
            yield return new WaitForSeconds(timetowait);
            text.text = string.Empty; //empties the screen once done

        }
    }
    private void OnDisable()
    {
        text.text = string.Empty;
        index = 0;  //empty string and reset so can be repeated
    }
}
