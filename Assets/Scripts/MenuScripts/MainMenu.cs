/*
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    void Start(){
        
    }

    public void PlayGame(){
        SceneManager.LoadSceneAsync(1);
    }
}
*/

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public float fadeDuration = 1f; // Geçiş süresi

    public void PlayGame()
    {
        StartCoroutine(LoadScene(1)); // İlk oyun sahnesine geçiş
    }

    IEnumerator LoadScene(int sceneIndex)
    {
        yield return new WaitForSeconds(fadeDuration); // İsteğe bağlı gecikme
        SceneManager.LoadScene(sceneIndex); // Yeni sahneyi yükle
    }
}

