using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

namespace Gamekit2D
{
    [RequireComponent(typeof(Slider))]
    public class MixerSliderLink : MonoBehaviour
    {
        public AudioMixer mixer;
        public string mixerParameter;

        public float maxAttenuation = 0.0f;
        public float minAttenuation = -80.0f;

        protected Slider m_Slider;


        void Awake ()
        {
            m_Slider = GetComponent<Slider>();

            float value;
            mixer.GetFloat(mixerParameter, out value);

            m_Slider.value = (value - minAttenuation) / (maxAttenuation - minAttenuation);

            m_Slider.onValueChanged.AddListener(SliderValueChange);
        }


        void SliderValueChange(float value)
        {
            mixer.SetFloat(mixerParameter, minAttenuation + value * (maxAttenuation - minAttenuation));

            if (mixerParameter == "MasterVolume")
            {
                AkSoundEngine.SetRTPCValue("Global_Volume", value);
            }

            if (mixerParameter == "MusicVolume")
            {
                AkSoundEngine.SetRTPCValue("Music_Volume", value);
            }

            if (mixerParameter == "SFXMasterVolume")
            {
                AkSoundEngine.SetRTPCValue("SFX_Volume", value);
            }

            //Debug.Log("slidervalue is" + value);
        }
    }
}