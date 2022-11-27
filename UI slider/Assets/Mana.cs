using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Mana : MonoBehaviour {
    public Slider slider;

    void Update (){
        slider.value = Mathf.MoveTowards (slider.value, 100.0f, 0.15f);
    }
}
