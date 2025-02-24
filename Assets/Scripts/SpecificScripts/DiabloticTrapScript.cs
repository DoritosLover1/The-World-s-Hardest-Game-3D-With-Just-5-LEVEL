using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class DiabloticTrapCode : MonoBehaviour
{   
    public GameObject wallOpen = null;
    public GameObject wallClosed = null;
    public Light trapTextLight = null;
    public GameObject trapTextTMP = null;
    public int awaitTime = 1000;
    [SerializeField] public GameObject trapBall;
    void Start()
    {
        wallOpen.SetActive(false);
    }
    async void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            wallOpen.SetActive(true);
            wallClosed.SetActive(false);

            trapTextLight.gameObject.SetActive(true);
            trapTextTMP.SetActive(true);
            
            await Task.Delay(awaitTime);
            trapBall.SetActive(true);
        }
    }
}
