using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Player hit an obstacle");

            playerMovement.enabled = false;
            FindObjectOfType<GameMasterMind>().EndGame();
        }
    }
}
