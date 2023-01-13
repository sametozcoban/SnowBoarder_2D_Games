using System.Collections;
using System.Collections.Generic;
using SnowBoarder.CrashControl;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    [SerializeField] int sceneIndex;
    [SerializeField] float reloadSceneTime;
    
    void Update()
    {
        Invoke("ReloadScene", reloadSceneTime);
    }

    public void ReloadScene()
    {
        if (CrashDetector.hasCrashed)
        {
            SceneManager.LoadScene(sceneIndex);
            CrashDetector.hasCrashed = false;
        }
    }

    public void PlayToLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void LevelSelectToEndless()
    {
        SceneManager.LoadScene("EndlessScene");
    }

    public void LevelSelectToJourney()
    {
        SceneManager.LoadScene("Level1");
    }

}
