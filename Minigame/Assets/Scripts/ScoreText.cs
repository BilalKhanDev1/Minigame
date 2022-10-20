using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    void Update()
    {
        GetComponent<TMP_Text>().SetText(MovingBlock.score.ToString());
    }
}
