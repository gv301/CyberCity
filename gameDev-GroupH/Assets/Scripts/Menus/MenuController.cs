using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public SaveData saveState;
    public Player ply;
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
        saveState.SaveLocation(new Vector3(0f, 0f, 0f));
        saveState.set_respawn(new Vector3(0f, 0f, 0f));
        saveState.set_item_respawn(4);
        saveState.SavePlayerMP(new int[] { 30, 30, 30, 30 });
        saveState.SavePlayerHealth(new int[] { ply.getTotalMaxHP(), ply.getTotalMaxHP(), ply.getTotalMaxHP(), ply.getTotalMaxHP() });
    }

    //starts the game when play button is pressed
    public void PlayGame()
    {
        initialiseGame(); //clears saved data variables
        SceneManager.LoadScene(saveState.get_cargo_battle());
    }

    //quits the game when the quit button is pressed
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit(); //application quits
    }
}

