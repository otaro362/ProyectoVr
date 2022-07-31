using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScen : MonoBehaviour
{
    public GameObject gameManager;
    public bool correct;
    public float totaltime;
    public Image fillAmount;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

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
                if (correct)
                {
                    gameManager.gameObject.GetComponent<ManagerEscenas>().ScenaManager(0);
                }
                else
                {
                    gameManager.gameObject.GetComponent<ManagerEscenas>().ScenaManager(1);
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
}
