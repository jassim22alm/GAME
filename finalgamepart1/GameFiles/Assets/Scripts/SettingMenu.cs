using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour
{
   public AudioMixer mainMixer;//a reference to the audio mixer

   public Dropdown resolutionDropdown;// a reference to the resolution dropdown

   Resolution[] resolutions;// the array for resolutions

   void Start ()
   {
          // represent all the avaiable resolutions depends on the device
          resolutions = Screen.resolutions;

          resolutionDropdown.ClearOptions();

          List<string> options = new List<string>();

          int currentResolutionIndex = 0;

          for (int i = 0; i < resolutions.Length; i++)
          {
                string option = resolutions[i].width + " x " + resolutions[i].height;
                options.Add(option);

                // automatically set the device's default resolution
                if (resolutions[i].width == Screen.currentResolution.width &&
                    resolutions[i].height == Screen.currentResolution.height)
                {
                    currentResolutionIndex = i;
                }
          }

          resolutionDropdown.AddOptions(options);
          resolutionDropdown.value = currentResolutionIndex;
          resolutionDropdown.RefreshShownValue();
   }

   public void SetResolution (int resolutionIndex)// to update the resolution
   {
          Resolution resolution = resolutions[resolutionIndex];
          Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
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
