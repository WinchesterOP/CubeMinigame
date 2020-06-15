using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreNumber : MonoBehaviour
{
    public Transform player;
    public Text textScore;

    private float playerStartPosition;

    private void Start()
    {
        playerStartPosition = player.position.z;   
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = (player.position.z - playerStartPosition).ToString("0");
    }
}
