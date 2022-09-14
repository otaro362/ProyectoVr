using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerEscenas : MonoBehaviour
{
    public string[] scenas;
    public GameObject[] panel;
    public GameObject canvasLoading;
    public bool canvasLoad;
    public void ScenaManager(int x)
    {
        if (canvasLoad)
        {
            SceneManager.LoadScene(scenas[x]);
        }
        else
        {
            StartCoroutine(ScenLoading(x));
        }
        
    }
    IEnumerator ScenLoading(int x)
    {
        canvasLoading.SetActive(true);
        canvasLoading.GetComponent<Animator>().SetBool("Enter",false);
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene(scenas[x]);
    }
    public void CanvasOff()
    {
        canvasLoading.SetActive(false);
    }
    public void ScenaMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void PanelActivate(int x)
    {
        for (int i = 0; i <panel.Length; i++)
        {
            panel[i].SetActive(false);
            panel[x].SetActive(true);
        }
    }
}
