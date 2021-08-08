using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    //�X�R�A��\������e�L�X�g
    private GameObject scoreText;

    //�X�R�A���Z�p
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������ScoreText�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("ScoreText");
    }


    void OnCollisionEnter(Collision other)
    {

        // �^�O�ɂ���ăX�R�A��ς���
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

        //ScoreText�ɃX�R�A��\��
        this.scoreText.GetComponent<Text>().text = "Score:" + score;
    }

}

