using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene2 : MonoBehaviour
{
    public void LevelGame()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex - 2;
        if (nextScene >= SceneManager.sceneCountInBuildSettings)
        {
            nextScene = 2;
        }
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(nextScene);
    }
}