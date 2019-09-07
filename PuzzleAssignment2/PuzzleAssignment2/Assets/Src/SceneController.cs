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

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            LoadNextScene();
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

}
