using UnityEngine;
using TMPro;
using UnityEngine.UI; // TMP için gerekli

public class ResolutionManager : MonoBehaviour
{
    [SerializeField] TMP_Dropdown resolutionDropdown;
    [SerializeField] Button applyButtonRef;
    [SerializeField] Button cancelButtonRef;
    private Resolution[] resolutions;
    private Resolution currentResolution;
    private int initialDropdownValue;

    void Start()
    {
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();

        // Dropdown'a çözünürlük seçeneklerini ekle
        for (int i = 0; i < resolutions.Length; i++)
        {
            resolutionDropdown.options.Add(new TMP_Dropdown.OptionData(resolutions[i].width + "x" + resolutions[i].height));
        }

        //resolutionDropdown.onValueChanged.AddListener(delegate { ChangeResolution(resolutionDropdown.value); });
        currentResolution = Screen.currentResolution;
        initialDropdownValue = resolutionDropdown.value;

        applyButtonRef.onClick.AddListener(ApplyResoulution);
        cancelButtonRef.onClick.AddListener(GetBackOldResolution);

        resolutionDropdown.value = GetCurrentResolutionIndex();
        resolutionDropdown.RefreshShownValue();
    }


/*
    void ChangeResolution(int index)
    {
        Resolution res = resolutions[index];
        Screen.SetResolution(res.width, res.height, Screen.fullScreen);
    }
*/

    void GetBackOldResolution(){
        Screen.SetResolution(currentResolution.width, currentResolution.height, Screen.fullScreen);

        resolutionDropdown.value = initialDropdownValue;
        resolutionDropdown.RefreshShownValue();
    }

    void ApplyResoulution(){
        int index = resolutionDropdown.value;
        Resolution res = resolutions[index];
        Screen.SetResolution(res.width, res.height, Screen.fullScreen);
        Debug.Log("Değişim gerçekleşti.");
    }
    int GetCurrentResolutionIndex()
    {
        for (int i = 0; i < resolutions.Length; i++)
        {
            if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)
                return i;
        }
        return 0;
    }
}

