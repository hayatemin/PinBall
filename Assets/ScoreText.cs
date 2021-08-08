using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    //スコアを表示するテキスト
    private GameObject scoreText;

    //スコア加算用
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
    }


    void OnCollisionEnter(Collision other)
    {

        // タグによってスコアを変える
        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            score += 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 15;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 30;
        }

        //ScoreTextにスコアを表示
        this.scoreText.GetComponent<Text>().text = "Score:" + score;
    }

}

