using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {
    public void Setup() {
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartButton() {
        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1;
    }

    public void ExitButton() {
        Application.Quit();
    }
}
