using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreNumber : MonoBehaviour
{
    public Transform player;
    public Text textScore;

    private float playerStartPosition;
    private float actualScore;

    private void Start()
    {
        playerStartPosition = player.position.z;
        // Bei der initierung wird der Score auf den letzten gespeicherten Wert gesetzt
        actualScore = PlayerPrefs.GetInt("ActualScore");
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = (player.position.z - playerStartPosition + actualScore).ToString("0") ;
    }
}
