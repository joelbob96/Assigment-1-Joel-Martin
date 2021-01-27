using UnityEngine;
using UnityEngine.UI;


public class Score1 : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = (player.position.z + 45).ToString("0");
    }
}
