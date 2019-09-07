using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private int currentScene; 
    private int sceneToLoad;
 
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            LoadNextScene();
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            LoadMainMenu();
        }
    }

    public void LoadNextScene()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        sceneToLoad = currentScene + 1;
        SceneManager.LoadScene(sceneToLoad);
    }

    public void LoadSameScene()
    {
        SceneManager.LoadScene(currentScene);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
