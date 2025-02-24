using UnityEngine;
using UnityEngine.UI;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private Transform playerBody;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerBody = transform.parent;
    }

    void LateUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * MouseSensitivitySetting.GetMouseSensitivity() * Time.deltaTime;

        // Karakteri sağa-sola döndür
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
