using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenue : MonoBehaviour
{
    private void Start()
    {
        // Setzt am Anfang des Spiels der ActualScore auf 0 damit er nicht weiter addiert wird
        PlayerPrefs.SetInt("ActualScore", 0);
        // Checkt ob der Wert Highscore bereits einen Wert hat. Wenn nicht wird er gesetzt. Initial Belegung
        if (!PlayerPrefs.HasKey("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", 0);
        }
            
    }

    public void StartLevel1()
    {
        SceneManager.LoadScene("LevelOne", LoadSceneMode.Single);
    }

    public void StartLevel2()
    {
        SceneManager.LoadScene("LevelTwo", LoadSceneMode.Single);
    }

    public void Quit()
    {
        Debug.Log("Game has ended");
        Application.Quit();
    }

    public void GetToHighscoreScene()
    {
        Debug.Log("HighScoreScene will be loaded");
        SceneManager.LoadScene("HighScoreScene", LoadSceneMode.Single);
    }
    
    // Funktion um die Ausgabewerte genauer zu betrachten im Log
    public void TestingSceneManager()
    {
        Debug.Log("Testing-Button has been pressed");

        var ActiveSceneName = SceneManager.GetActiveScene().name;
        var ActiveSceneBuildIndex = SceneManager.GetActiveScene().buildIndex;
        var SceneByNameBuildIndex = SceneManager.GetSceneByName("StartMenue").buildIndex;

        Debug.Log(ActiveSceneName);
        Debug.Log(ActiveSceneBuildIndex);
        Debug.Log(SceneByNameBuildIndex);
    }
}
