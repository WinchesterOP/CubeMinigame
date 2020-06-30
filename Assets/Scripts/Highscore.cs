using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Highscore-Value").GetComponent<Text>().text = PlayerPrefs.GetInt("Highscore").ToString();
    }

    public void GetBackToStartMenue()
    {
        SceneManager.LoadScene("StartMenue", LoadSceneMode.Single);
    }
}
