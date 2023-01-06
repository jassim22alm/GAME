using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour
{
   public AudioMixer mainMixer;//a reference to the audio mixer

   public Dropdown resolutionDropdown;// a reference to the resolution dropdown

   Resolution[] resolutions;

   void Start ()
   {
          resolutions = Screen.resolutions;

          resolutionDropdown.ClearOptions();

          List<string> options = new List<string>();

          for (int i = 0; i < resolutions.Length; i++)
          {
                string option = resolutions[i].width + " x " + resolutions[i].height;
                options.Add(option);
          }

          resolutionDropdown.AddOptions(options);
   }

   public void SetVolume(float volume)// to increase or decrease the volume
   {
         mainMixer.SetFloat("volume",volume);
   }
   
   public void SetQuality(int qualityIndex)// to game change the quality 
   {
          QualitySettings.SetQualityLevel(qualityIndex);
   }

   public void SetFullscreen (bool isFullscreen)// to set full screen
   {
          Screen.fullScreen = isFullscreen;
   }
}
