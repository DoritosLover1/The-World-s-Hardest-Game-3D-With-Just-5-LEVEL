using UnityEngine;
using UnityEngine.SceneManagement;

public class BallsMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.4f;
    float xValue = 0;

    public Texture myTexture; // Unity Inspector'dan bir texture ekleyebilirsin

    void Start()
    {
        GetComponent<Renderer>().material.mainTexture = myTexture;
    }
    
    void Update()
    {
        BallMove();
    }

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != "Player")
        {
            moveSpeed = -moveSpeed; // Hareket yönünü ters çevir
        }

        if (other.gameObject.tag == "Player"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void BallMove()
    {
        xValue = 10 * moveSpeed * Time.deltaTime;
        transform.Translate(xValue, 0, 0);
    }
}
