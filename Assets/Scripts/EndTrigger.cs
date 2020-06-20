using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameMasterMind gameMasterMind;

    void OnTriggerEnter()
    {
        gameMasterMind.CompleteLevel();
    }
}
