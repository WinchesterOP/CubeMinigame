using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Player hit an obstacle");
            // Letzter Wert des Score wird ausgelesen zum Ende
            string ScoreAtEnd = GameObject.FindGameObjectWithTag("Score-Text").GetComponent<Text>().text;
            Debug.Log("Der Score am Ende des Levels ist: " + ScoreAtEnd);

            // Letzter Wert wird vor dem Szenenwechsel gespeichert
            PlayerPrefs.SetInt("ActualScore", int.Parse(ScoreAtEnd));

            playerMovement.enabled = false;
            FindObjectOfType<GameMasterMind>().CompleteLevel();
            //FindObjectOfType<GameMasterMind>().EndGame();
        }
    }
}










        
        

        