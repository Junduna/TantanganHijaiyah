using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoalManager : MonoBehaviour
{
    [System.Serializable]
    public class Soal
    {
        // [Header("Kumpulan Soal Gambar")]
        // public Sprite gambarSoal;

        [TextArea]
        [Header("Kumpulan Soal")]
        public string soal; 

        [Header("Pilihan Jawaban")]
        public string pilA;
        public string pilB, pilC;

        [Header("Kunci Jawaban")]
        public bool A;
        public bool B, C;
    }

    public GameObject Selesai;
    public float waktu;
    public int skor;
    private int nilaiAcak;
    Text textSoal, textA, textB, textC,textWaktu;
    public List<Soal> KumpulanSoal;
    void Start()
    {
        // SpriteRenderer spriteRenderer = GameObject.Find("GambarSoal").GetComponent<SpriteRenderer>();
        textSoal = GameObject.Find("TextSoal").GetComponent<Text>();
        textA = GameObject.Find("A").transform.GetComponent<Text>();
        textB = GameObject.Find("B").transform.GetComponent<Text>();
        textC = GameObject.Find("C").transform.GetComponent<Text>();

        textWaktu = GameObject.Find("TextWaktu").transform.GetComponent<Text>();        

        nilaiAcak = Random.Range(0, KumpulanSoal.Count);
    }

    void Update()
    {
        if(KumpulanSoal.Count>0){
        if (nilaiAcak >= KumpulanSoal.Count)
        {
            nilaiAcak = 0;
        }
    }

        textWaktu.text = "Waktu : " + waktu.ToString("0");
        waktu -= Time.deltaTime;

        if(waktu <= 0)
        {
            KumpulanSoal.RemoveAt(nilaiAcak);
            waktu =5;
            nilaiAcak = Random.Range(0, KumpulanSoal.Count);
        }

        if(KumpulanSoal.Count >0)
        {
        textSoal.text = KumpulanSoal[nilaiAcak].soal;
        textA.text = KumpulanSoal[nilaiAcak].pilA;
        textB.text = KumpulanSoal[nilaiAcak].pilB;
        textC.text = KumpulanSoal[nilaiAcak].pilC;
        }
        else
        {
            Selesai.SetActive(true);
            textSoal.text = "Skor : " +skor;
            if(GameObject.Find("TextWaktu"))
            {
                GameObject.Find("TextWaktu").SetActive(false);
            }
            
            if(GameObject.Find("Panel"))
            {
                GameObject.Find("Panel").SetActive(false);
            }
        }
            
    }

    public void cekJawaban(string jawaban)
    {
        if(KumpulanSoal[nilaiAcak].A == true && jawaban=="a")
        {
            skor++;
            Debug.Log("Jawaban Benar");
        }

        if(KumpulanSoal[nilaiAcak].B == true && jawaban=="b")
        {
            skor++;
            Debug.Log("Jawaban Benar");
        }

        if(KumpulanSoal[nilaiAcak].C == true && jawaban=="c")
        {
            skor++;
            Debug.Log("Jawaban Benar");
        }
        KumpulanSoal.RemoveAt(nilaiAcak);
        nilaiAcak = Random.Range(0, KumpulanSoal.Count);
        waktu = 5;
    }

    public void Repeat()
    {
        // Application.LoadLevel(Application.loadedLevel);
        // LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void OnSelesaiButtonClick()
    {
        Debug.Log("Selesai button diklik");
    }

}
