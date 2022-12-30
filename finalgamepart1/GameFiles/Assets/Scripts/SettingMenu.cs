using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer mainMixer;//a reference to the audio mixer
   public void SetVolume(float volume)// to increase or decrease the volume
   {
         mainMixer.SetFloat("volume",volume);
   }
   
   public void SetQuality(int qualityIndex)// to game change the quality 
   {
          QualitySettings.SetQualityLevel(qualityIndex);
   }
}
