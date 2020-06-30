using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public GameMasterMind gameMasterMind;

    void OnTriggerEnter()
    {
        // Letzter Wert des Score wird ausgelesen zum Ende
        string ScoreAtEnd = GameObject.FindGameObjectWithTag("Score-Text").GetComponent<Text>().text;

        Debug.Log("Der Score am Ende des Levels ist: " + ScoreAtEnd);

        // Letzter Wert wird vor dem Szenenwechsel gespeichert
        PlayerPrefs.SetInt("ActualScore",int.Parse(ScoreAtEnd));

        gameMasterMind.CompleteLevel();
    }
}
