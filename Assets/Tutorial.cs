using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorial : MonoBehaviour
{
    public string[] textTuto;
    public TMP_Text dialogBox;
    public float time;
    public int indText;
    public GameObject ctRg;
    public GameObject ct1Rg;
    public GameObject ctLf;
    public GameObject ct1Lf;
    public GameObject headSet;
    public Color32 ColorCT;
    public Material BotonCt1Rg;
    public Material BotonCt2Rg;
    public Material BotonCt3Rg;
    public Material BotonCt1Lf;
    public Material BotonCt2Lf;
    public Material BotonCt3Lf;
    public GameObject Table;
    public TMP_Text question;
    public TMP_Text response1;
    public TMP_Text response2;
    public TMP_Text response3;
    public TMP_Text response4;
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public GameObject boton1;
    public GameObject boton2;
    public GameObject boton3;
    public GameObject boton4;



    // Start is called before the first frame update
    void Start()
    {

        //StartCoroutine(TextDial());
        //QuestionOne();
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Init() 
    {
        StartCoroutine(TextDial());
    }
    IEnumerator TextDial()
    {
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        yield return new WaitForSecondsRealtime(10);
        indText=1;
        dialogBox.text=textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        yield return new WaitForSecondsRealtime(10);
        indText=2;
        dialogBox.text=textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        yield return new WaitForSecondsRealtime(10);
        indText=3;
        dialogBox.text=textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        headSet.SetActive(true);
        yield return new WaitForSecondsRealtime(10);
        indText=4;
        dialogBox.text=textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        yield return new WaitForSecondsRealtime(10);
        indText=5;
        dialogBox.text=textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        yield return new WaitForSecondsRealtime(10);
        indText=6;
        dialogBox.text=textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        yield return new WaitForSecondsRealtime(10);
        indText=7;
        dialogBox.text=textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        headSet.SetActive(false);
        yield return new WaitForSecondsRealtime(10);
        indText=8;
        dialogBox.text=textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        ctRg.SetActive(true);
        yield return new WaitForSecondsRealtime(10);
        indText=9;
        dialogBox.text=textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        ct1Rg.SetActive(true);
        yield return new WaitForSecondsRealtime(10);
        indText=10;
        dialogBox.text=textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        BotonCt1Rg.color=ColorCT;
        BotonCt2Rg.color=ColorCT;
        BotonCt3Rg.color=ColorCT;
        yield return new WaitForSecondsRealtime(30);
        indText=11;
        dialogBox.text=textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        yield return new WaitForSecondsRealtime(10);
        indText = 12;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        headSet.SetActive(false);
        ctRg.SetActive(false);
        ct1Rg.SetActive(false);
        yield return new WaitForSecondsRealtime(10);
        indText = 13;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        ctLf.SetActive(true);
        yield return new WaitForSecondsRealtime(10);
        indText = 14;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        ct1Lf.SetActive(true);
        yield return new WaitForSecondsRealtime(10);
        indText = 15;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        BotonCt1Lf.color = Color.white;
        BotonCt2Lf.color = ColorCT;
        BotonCt3Lf.color = ColorCT;
        yield return new WaitForSecondsRealtime(30);
        indText = 16;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        Perfect();
        ctLf.SetActive(false);
        ct1Lf.SetActive(false);
        yield return new WaitForSecondsRealtime(10);
        QuestionOne();
    }
    public void QuestionOne()
    {
        StartCoroutine(QuestionOneIEn());
    }
    IEnumerator QuestionOneIEn()
    {
        yield return new WaitForSecondsRealtime(5);
        indText = 17;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        yield return new WaitForSecondsRealtime(5);
        indText = 18;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        Table.SetActive(true);
        yield return new WaitForSecondsRealtime(5);
        indText = 19;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        yield return new WaitForSecondsRealtime(5);
        indText = 20;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        yield return new WaitForSecondsRealtime(5);
        indText = 21;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        yield return new WaitForSecondsRealtime(5);
        ct1Rg.SetActive(true);
        ButoonOnOff();
        BotonCt1Rg.color = Color.white;
        BotonCt2Rg.color = Color.white;
        BotonCt3Rg.color = ColorCT;
        indText = 22;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        question.text = "¿De que color es el cielo?";
        response1.text = "Negro";
        response1.gameObject.GetComponentInParent<Question>().index = 4;
        response2.text = "Azul";
        response2.gameObject.GetComponentInParent<Question>().index = 1;
        response3.text = "Rojo";
        response3.gameObject.GetComponentInParent<Question>().index = 4;
        response4.text = "Verde";
        response4.gameObject.GetComponentInParent<Question>().index = 4;
        yield return new WaitForSecondsRealtime(5);
        indText = 23;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        yield return new WaitForSecondsRealtime(8);
        indText = 24;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        response1.gameObject.GetComponentInParent<BoxCollider>().enabled = true;
        response2.gameObject.GetComponentInParent<BoxCollider>().enabled = true;
        response3.gameObject.GetComponentInParent<BoxCollider>().enabled = true;
        response4.gameObject.GetComponentInParent<BoxCollider>().enabled = true;
    }
    public void QuestionTwo()
    {
        StartCoroutine(QuestionTwoIEn());
    }
    IEnumerator QuestionTwoIEn() 
    {
        yield return new WaitForSecondsRealtime(5);
        indText = 25;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        yield return new WaitForSecondsRealtime(5);
        ct1Rg.SetActive(true);
        ButoonOnOff();
        BotonCt1Rg.color = Color.white;
        BotonCt2Rg.color = Color.white;
        BotonCt3Rg.color = ColorCT;
        indText = 26;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        question.text = "¿Cuantos es 2+2?";
        response1.text = "8";
        response1.gameObject.GetComponentInParent<Question>().index = 5;
        response2.text = "15";
        response2.gameObject.GetComponentInParent<Question>().index = 5;
        response3.text = "248";
        response3.gameObject.GetComponentInParent<Question>().index = 5;
        response4.text = "4";
        response4.gameObject.GetComponentInParent<Question>().index = 2;
        yield return new WaitForSecondsRealtime(5);
        indText = 27;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        yield return new WaitForSecondsRealtime(8);
        indText = 28;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        response1.gameObject.GetComponentInParent<BoxCollider>().enabled = true;
        response2.gameObject.GetComponentInParent<BoxCollider>().enabled = true;
        response3.gameObject.GetComponentInParent<BoxCollider>().enabled = true;
        response4.gameObject.GetComponentInParent<BoxCollider>().enabled = true;
    }
    public void QuestionTree()
    {
        StartCoroutine(QuestionTreeIEn());
    }
    IEnumerator QuestionTreeIEn() 
    {
        yield return new WaitForSecondsRealtime(5);
        indText = 29;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        yield return new WaitForSecondsRealtime(5);
        indText = 30;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        yield return new WaitForSecondsRealtime(5);
        ct1Rg.SetActive(true);
        ButoonOnOff();
        BotonCt1Rg.color = Color.white;
        BotonCt2Rg.color = Color.white;
        BotonCt3Rg.color = ColorCT;
        indText = 31;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        question.text = "¿Entendiste la forma de contestar las preguntas?";
        response1.text = "No";
        response1.gameObject.GetComponentInParent<Question>().index = 6;
        response2.text = "Mas O Menos";
        response2.gameObject.GetComponentInParent<Question>().index = 6;
        response3.text = "Si";
        response3.gameObject.GetComponentInParent<Question>().index = 3;
        response4.text = "Casi no";
        response4.gameObject.GetComponentInParent<Question>().index = 6;
        yield return new WaitForSecondsRealtime(5);
        indText = 32;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
        response1.gameObject.GetComponentInParent<BoxCollider>().enabled= true;
        response2.gameObject.GetComponentInParent<BoxCollider>().enabled = true;
        response3.gameObject.GetComponentInParent<BoxCollider>().enabled = true;
        response4.gameObject.GetComponentInParent<BoxCollider>().enabled = true;

        
    }
    public void Perfect()
    {
        indText = 6;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[6];
        audioSource.Play();
    }
    public void EndTutorial() 
    {
        StartCoroutine(EndTutorialIEn());
    }
    IEnumerator EndTutorialIEn()
    {
        yield return new WaitForSecondsRealtime(8);
        indText = 33;
        dialogBox.text = textTuto[indText];
        audioSource.clip = audioClips[indText];
        audioSource.Play();
    }
    public void ButoonOnOff()
    {
        if (boton1.activeInHierarchy)
        {
            boton1.SetActive(false);
            boton2.SetActive(false);
            boton3.SetActive(false);
            boton4.SetActive(false);
        }
        else
        {
            boton1.SetActive(true);
            boton2.SetActive(true);
            boton3.SetActive(true);
            boton4.SetActive(true);
        }
    }
    public void ActColl()
    {
        if (response1.gameObject.GetComponentInParent<BoxCollider>().enabled == true)
        {
            response1.gameObject.GetComponentInParent<BoxCollider>().enabled = false;
            response2.gameObject.GetComponentInParent<BoxCollider>().enabled = false;
            response3.gameObject.GetComponentInParent<BoxCollider>().enabled = false;
            response4.gameObject.GetComponentInParent<BoxCollider>().enabled = false;
        }
        else
        {
            response1.gameObject.GetComponentInParent<BoxCollider>().enabled = true;
            response2.gameObject.GetComponentInParent<BoxCollider>().enabled = true;
            response3.gameObject.GetComponentInParent<BoxCollider>().enabled = true;
            response4.gameObject.GetComponentInParent<BoxCollider>().enabled = true;
        }
    }
}
