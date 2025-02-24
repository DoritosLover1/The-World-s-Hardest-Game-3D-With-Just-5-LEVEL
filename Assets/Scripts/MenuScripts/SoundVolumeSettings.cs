using UnityEngine;
using UnityEngine.UI;

public class SoundVolumeSettings : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private Button cancelButton;
    [SerializeField] private Button applyButton;

    public static float soundVolume = 0.2f;
    private float oldVolume;
    
    void Start()
    {
        volumeSlider.value = soundVolume;
        volumeSlider.onValueChanged.AddListener(SetVolumeSetting);

        oldVolume = soundVolume;

        applyButton.onClick.AddListener(ApplyVolume);
        cancelButton.onClick.AddListener(GetBackOldVolume);

        AudioListener.volume = soundVolume;
    }
    private void ApplyVolume(){
        oldVolume = volumeSlider.value;
        SetVolumeSetting(volumeSlider.value);
    }

    private void GetBackOldVolume(){
        volumeSlider.value = oldVolume;
    }

    private void SetVolumeSetting(float value){
        soundVolume = value;
        AudioListener.volume = value;
    }
}
