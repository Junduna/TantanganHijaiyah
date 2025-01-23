using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public GameObject buttonAToWhite; //posisi idle
    public GameObject buttonAToGreen; //berubah warna (BENAR)
    public GameObject buttonAToRed; //salah
    public GameObject buttonBToWhite;
    public GameObject buttonBToGreen;
    public GameObject buttonBToRed;
    public GameObject buttonCToWhite;
    public GameObject buttonCToGreen;
    public GameObject buttonCToRed;
    public GameObject buttonA;
    public GameObject buttonB;
    public GameObject buttonC;

    public AudioSource CorrectFX;
    public AudioSource WrongFx;
    public GameObject currentScore;
    public int scoreValue;

    void Update()
    {
        currentScore.GetComponent<Text>().text = "Score :"+scoreValue;
    }

   public void ButtonA()
   {
        if(QuestionGenerator.actualAnswer == "A") 
        {
            buttonAToGreen.SetActive(true);
            buttonAToWhite.SetActive(false);
            CorrectFX.Play();
            scoreValue +=10;

        }
        else
        {
            buttonAToRed.SetActive(true);
            buttonAToWhite.SetActive(false);
            WrongFx.Play();
            scoreValue = 0;
        }
        buttonA.GetComponent<Button>().enabled = false;
        Debug.Log("Button clicked"+QuestionGenerator.actualAnswer);
        buttonB.GetComponent<Button>().enabled = false;
        buttonC.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
   }

   public void ButtonB()
   {
        if(QuestionGenerator.actualAnswer == "B") 
        {
            buttonBToGreen.SetActive(true);
            buttonBToWhite.SetActive(false);
            CorrectFX.Play();
            scoreValue +=10;
        }
        else
        {
            buttonBToRed.SetActive(true);
            buttonBToWhite.SetActive(false);
            WrongFx.Play();
            scoreValue = 0;
        }
        buttonA.GetComponent<Button>().enabled = false;
        buttonB.GetComponent<Button>().enabled = false;
        buttonC.GetComponent<Button>().enabled = false;
   }

   public void ButtonC()
   {
        if(QuestionGenerator.actualAnswer == "C") 
        {
            buttonCToGreen.SetActive(true);
            buttonCToWhite.SetActive(false);
            CorrectFX.Play();
            scoreValue +=10;
        }
        else
        {
            buttonCToRed.SetActive(true);
            buttonCToWhite.SetActive(false);
            WrongFx.Play();
            scoreValue = 0;
        }
        buttonA.GetComponent<Button>().enabled = false;
        buttonB.GetComponent<Button>().enabled = false;
        buttonC.GetComponent<Button>().enabled = false;
   }

   IEnumerator NextQuestion()
   {
    yield return new WaitForSeconds(2);

    buttonAToGreen.SetActive(false);
    buttonBToGreen.SetActive(false);
    buttonCToGreen.SetActive(false);
    buttonAToRed.SetActive(false);
    buttonBToRed.SetActive(false);
    buttonCToRed.SetActive(false);
    buttonAToWhite.SetActive(true);
    buttonBToWhite.SetActive(true);
    buttonCToWhite.SetActive(true);
    buttonA.GetComponent<Button>().enabled = true;
    buttonB.GetComponent<Button>().enabled = true;
    buttonC.GetComponent<Button>().enabled = true;
    QuestionGenerator.displayingQuestion = false;
   }
}
