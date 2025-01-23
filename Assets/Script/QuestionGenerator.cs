using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{
   public static string actualAnswer;
   public static bool displayingQuestion = false;
   public int questionNumber;

    void Update()
    {
        if(displayingQuestion == false)
        {
            displayingQuestion = true;
            if(questionNumber == 1)            
        {
            QuestionDisplay.newQuestion = "huruf ini dibaca?";
            QuestionDisplay.newA = "A";
            QuestionDisplay.newB = "Ba";
            QuestionDisplay.newC = "Ta";
            actualAnswer = "A";
        }
        if(questionNumber == 2)            
        {
            QuestionDisplay.newQuestion = "huruf ini dibaca?";
            QuestionDisplay.newA = "Tsa";
            QuestionDisplay.newB = "Ja";
            QuestionDisplay.newC = "Ha";
            actualAnswer = "C";
        }
        if(questionNumber == 3)            
        {
            QuestionDisplay.newQuestion = "huruf ini dibaca?";
            QuestionDisplay.newA = "Tsa";
            QuestionDisplay.newB = "Ja";
            QuestionDisplay.newC = "Ha";
            actualAnswer = "B";
        }
        if(questionNumber == 4)            
        {
            QuestionDisplay.newQuestion = "huruf ini dibaca?";
            QuestionDisplay.newA = "Tsa";
            QuestionDisplay.newB = "Ja";
            QuestionDisplay.newC = "Ha";
            actualAnswer = "A";
        }
        if(questionNumber == 5)            
        {
            QuestionDisplay.newQuestion = "huruf ini dibaca?";
            QuestionDisplay.newA = "Tsa";
            QuestionDisplay.newB = "Ja";
            QuestionDisplay.newC = "Ha";
            actualAnswer = "A";
        }
        if(questionNumber == 6)            
        {
            QuestionDisplay.newQuestion = "huruf ini dibaca?";
            QuestionDisplay.newA = "Tsa";
            QuestionDisplay.newB = "Ja";
            QuestionDisplay.newC = "Ha";
            actualAnswer = "C";
        }
        if(questionNumber == 7)            
        {
            QuestionDisplay.newQuestion = "huruf ini dibaca?";
            QuestionDisplay.newA = "Tsa";
            QuestionDisplay.newB = "Ja";
            QuestionDisplay.newC = "Ha";
            actualAnswer = "B";
        }
    }
}
}