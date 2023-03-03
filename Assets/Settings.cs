using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public AudioMixer audiomix;

   public void ValeurVolume (float volume)
    {
        audiomix.SetFloat("boil", volume);
    }
}
