using UnityEngine;
using UnityEngine.UI;
using Unity.Collections;

public class RotatorSlider : MonoBehaviour
{
    public Slider slider;

    void Update()
    {
       transform.localEulerAngles = new Vector3(0, slider.value, 0); 
    }
}
