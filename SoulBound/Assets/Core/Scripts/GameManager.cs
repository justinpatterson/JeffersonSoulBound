using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public enum GameStates 
    {
        Launch = 0,
        MainMenu = 1
    }
    public GameStates activeState = GameStates.Launch;

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

    private void Start()
    {
        if(SceneManager.instance != null) 
        {
            SceneManager.instance.LoadSceneTarget();
            activeState = GameStates.MainMenu;
        }
    }
}
