using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarreDeVieEnemy : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHpEnemy(int hp)
    {
        slider.maxValue = hp;
        slider.value = hp;
    }

    public void SetHpEnemy (int hp)
    {
        slider.value = hp;
    }



}
