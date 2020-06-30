using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndButtons : MonoBehaviour
{
    private void Start()
    {
        int actualScore = PlayerPrefs.GetInt("ActualScore");
        int highscore = PlayerPrefs.GetInt("Highscore");
        GameObject.Find("Ending Score-Value").GetComponent<Text>().text = actualScore.ToString();

        if (actualScore > highscore)
        {
            PlayerPrefs.SetInt("Highscore", actualScore);
        }
    }

    public void Quit()
    {
        Debug.Log("Game has ended");
        Application.Quit();
    }

    public void RestartGame()
    {
        Debug.Log("Game has been restarted");
      
        /**
         * GetSceneByName ging nicht weil die Szene nicht mehr geladen war und somit nicht gefunden wurde.
         * Die Szene StartMenue musste direkt gewählt werden mit dem LoadSceneMode
         */
        SceneManager.LoadScene("StartMenue", LoadSceneMode.Single);

   

    }
}
