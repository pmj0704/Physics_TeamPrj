using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    //ΩÃ±€≈Ê
    private static GameOver instance = null;
    public static GameOver Instance
    {
        get
        {
            if (!instance)
            {
                instance = FindObjectOfType<GameOver>();
                if (!instance)
                {
                    instance = new GameObject("GameOver").AddComponent<GameOver>();
                }
            }
            return instance;
        }
    }

    public void OnRetry()
    {
        SceneManager.LoadScene(1);
        
    }
    
}
