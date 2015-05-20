using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    static LevelManager instance = null;

    void Start()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            print("Duplicate level manager self-destructing!");
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void LoadLevel(string name)
    {
        Debug.Log("New Level load: " + name);
        Application.LoadLevel(name);
    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }

}
