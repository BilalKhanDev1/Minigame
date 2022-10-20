using UnityEngine;
using TMPro;

public class HighScoreText : MonoBehaviour
{
    void Update()
    {
        GetComponent<TMP_Text>().SetText("High Score: " + MovingBlock.highscore.ToString());
    }
}
