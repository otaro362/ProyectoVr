using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Question : MonoBehaviour
{
    public int index;
    public Image fillAmount;
    public float totaltime;
    float time = 0;
    public GameObject canvasRes;
    public Tutorial tutorial;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<Image>().color = new Color32(178, 178, 202, 255);
            fillAmount.gameObject.SetActive(true);

        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            time += Time.deltaTime;
            fillAmount.transform.GetChild(0).GetComponent<Image>().fillAmount = time / totaltime;
            if (time >= totaltime)
            {
                canvasRes.SetActive(true);
                if (index==1)
                {
                    canvasRes.transform.GetChild(0).GetComponent<TMP_Text>().text = "Correcto";
                    tutorial.Perfect();
                    canvasRes.SetActive(false);
                    tutorial.QuestionTwo();
                    ResetBoton();
                    
                    
                }
                else if(index==2)
                {
                    canvasRes.transform.GetChild(0).GetComponent<TMP_Text>().text = "Correcto";
                    tutorial.Perfect();
                    canvasRes.SetActive(false);
                    tutorial.QuestionTree();
                    ResetBoton();

                }
                else if (index==3)
                {
                    canvasRes.transform.GetChild(0).GetComponent<TMP_Text>().text = "Correcto";
                    tutorial.Perfect();
                    tutorial.EndTutorial();
                    ResetBoton();

                    
                }
                else if (index == 4)
                {
                    canvasRes.transform.GetChild(0).GetComponent<TMP_Text>().text = "Incorrecto";
                    canvasRes.SetActive(false);
                    tutorial.QuestionOne();
                    ResetBoton();

                }
                else if (index == 5)
                {
                    canvasRes.transform.GetChild(0).GetComponent<TMP_Text>().text = "Incorrecto";
                    canvasRes.SetActive(false);
                    tutorial.QuestionTwo();
                    ResetBoton();

                }
                else if (index == 6)
                {
                    canvasRes.transform.GetChild(0).GetComponent<TMP_Text>().text = "Incorrecto";
                    canvasRes.SetActive(false);
                    tutorial.QuestionTree();
                    ResetBoton();

                }

            }
            Debug.Log(111);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            time = 0;
            GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            fillAmount.gameObject.SetActive(false);
            Debug.Log(222);
        }
    }
    public void ResetBoton()
    {
        time = 0;
        GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        fillAmount.gameObject.SetActive(false);
        tutorial.ActColl();
        tutorial.ButoonOnOff();
        Debug.Log(222);
    }
}
