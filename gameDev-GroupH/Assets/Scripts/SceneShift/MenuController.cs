using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public SaveData saveState;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    //clears all saved data variables
    public void initialiseGame()
    {
        Time.timeScale = 1.0f;
        saveState.Clue.Clear();
        saveState.Death.Clear();
        saveState.ClueCount = 0;
        saveState.SaveLocation((float)-115.4, 1, (float)-65.9);
    }

    //starts the game when play button is pressed
    public void PlayGame()
    {
        initialiseGame(); //clears saved data variables
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //quits the game when the quit button is pressed
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit(); //application quits
    }
}
