using UnityEngine;
using System.Collections;

public class LoadNextScene : MonoBehaviour {

    public void LoadNextLevel()
    {
        int i = Application.loadedLevel;
        Application.LoadLevel(i + 1);
    }
}
