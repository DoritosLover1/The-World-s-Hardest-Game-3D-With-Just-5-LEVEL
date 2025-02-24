using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelTeleporter : MonoBehaviour
{
    [SerializeField] private int level;
    public float fadeDuration = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player")
            PlayGame();
    }
    
    public void PlayGame(){
        StartCoroutine(LoadScene(level));
    }

    IEnumerator LoadScene(int sceneIndex)
    {
        yield return new WaitForSeconds(fadeDuration);
        SceneManager.LoadScene(sceneIndex);
    }
}
