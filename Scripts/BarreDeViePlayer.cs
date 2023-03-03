using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarreDeViePlayer : MonoBehaviour
{
    public Slider slider;
    
    public void SetMaxHpPlayer(int hp)
    {
        slider.maxValue = hp;
        slider.value = hp;
    }

    public void SetHpPlayer (int hp)
    {
        slider.value = hp;
    }
   
}
