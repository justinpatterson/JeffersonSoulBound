using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public static SceneManager instance;

    int _lastScene = -1;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(this.gameObject);
    }

    public void LoadSceneTarget(int index = 1)  //LoadSceneTarget( targetScene );
    {
        //TODO: Unload any previous addidive scenes, probs
        if(_lastScene != -1 && _lastScene != 0) 
        {
            UnityEngine.SceneManagement.SceneManager.UnloadScene(_lastScene);
            _lastScene = -1;
        }

        //then, load the current scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(index, UnityEngine.SceneManagement.LoadSceneMode.Additive);
        _lastScene = index;
    }
}
