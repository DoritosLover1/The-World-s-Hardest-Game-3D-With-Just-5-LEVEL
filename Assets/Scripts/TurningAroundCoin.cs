using UnityEngine;

public class TurningAroundCoin : MonoBehaviour
{
    [SerializeField] float yRotation = 0.3f;
    [SerializeField] float distance = 0.05f;
    [SerializeField] float moveSpeed = 0.01f;

    private Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float y = startPos.y + Mathf.PingPong(Time.time * moveSpeed, distance);
        transform.position = new Vector3(startPos.x, y, startPos.z);
        TurnAround();
    }

    void OnCollisionEnter(Collision collision)
    {
        //(collision.gameObject.tag == "Player")

    }

    void TurnAround(){
        transform.Rotate(0, yRotation, 0);
    }

}
