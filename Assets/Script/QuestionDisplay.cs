using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay : MonoBehaviour
{
    public GameObject screenQuestion;
    public GameObject buttonA;
    public GameObject buttonB;
    public GameObject buttonC;
    public static string newQuestion;
    public static string newA;
    public static string newB;
    public static string newC;
    public static Sprite newQuestionImage;
    void Start()
    {
        StartCoroutine(PushTextOnScreen());
    }

    void Update()
    {
        
    }
    IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        if (screenQuestion != null && screenQuestion.GetComponent<Text>() != null)
        {
            screenQuestion.GetComponent<Text>().text = "Huruf alif dibaca?";
        }
        buttonA.GetComponent<Text>().text = newA;
        buttonB.GetComponent<Text>().text = newB;
        buttonC.GetComponent<Text>().text = newC;
    }
}
