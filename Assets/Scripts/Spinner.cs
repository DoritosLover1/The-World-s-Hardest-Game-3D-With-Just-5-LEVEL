using UnityEngine;
using UnityEngine.SceneManagement;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xRotation = 0f;
    [SerializeField] float yRotation = 1f;
    [SerializeField] float zRotation = 0f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotation, yRotation, zRotation); 
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
