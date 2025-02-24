using UnityEngine;
using UnityEngine.UI;

public class MouseSensitivitySetting : MonoBehaviour
{
    [SerializeField] private Slider sensitivitySlider;
    [SerializeField] private Button cancelButton;
    [SerializeField] private Button applyButton;
    
    public static float mouseSensitivity = 100f;
    private float oldSensitivity;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;

        sensitivitySlider.value = mouseSensitivity;
        sensitivitySlider.onValueChanged.AddListener(SetMouseSensitivity);

        oldSensitivity = mouseSensitivity;

        applyButton.onClick.AddListener(ApplySensitivity);
        cancelButton.onClick.AddListener(GetBackOlSensitivity);
    }

    static public float GetMouseSensitivity()
    {
        return mouseSensitivity;
    }

    void ApplySensitivity()
    {
        oldSensitivity = sensitivitySlider.value; // Yeni değeri kaydet
        SetMouseSensitivity(sensitivitySlider.value);
    }

    void GetBackOlSensitivity()
    {
        sensitivitySlider.value = oldSensitivity; // Eski değere geri dön
    }

    public void SetMouseSensitivity(float value)
    {
        mouseSensitivity = value; 
    }
}
