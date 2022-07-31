using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateBotones : MonoBehaviour
{
    public int index;
    public GameManager gameManager;
    public Image fillAmount;
    public float totaltime;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.botones.Add(this.gameObject);
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
        if (other.tag=="Player")
        {
            time += Time.deltaTime;
            fillAmount.transform.GetChild(0).GetComponent<Image>().fillAmount = time / totaltime;
            if (time>=totaltime)
            {
                gameManager.Respuesta(index);
                gameManager.DesBotones();
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
