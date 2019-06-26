using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;

public class SelectTrainingButton : MonoBehaviour
{
    public GameObject WordsPanel;
    void Start()
    {
        //Button b = this.GetComponent<Button>();
        //b.onClick.AddListener(delegate { btn_onClick(b); });
        //SceneManager.sceneLoaded += SceneManager_sceneLoaded;
    }

    private void SceneManager_sceneLoaded(Scene sender, LoadSceneMode arg1)
    {
        //if (sender.name == "Words")
        //{
        //    var title = FindObjectsOfType<Text>().First(obj => obj.name == "Title");
        //    Debug.Log(StaticScript.nameBut);
        //    if (title.text == "Title")
        //        title.text = StaticScript.nameBut;
        //}
    }

    void btn_onClick(Button sender)
    {
        //StaticScript.nameBut = sender.GetComponentInChildren<Text>().text;
        //StaticScript.fileName = sender.name + "." + sender.GetComponentInChildren<Text>().text + ".txt";
        //WordsPanel.GetComponentInChildren<Text>().text = StaticScript.nameBut;
        //Debug.Log(StaticScript.nameBut);
        //SceneManager.LoadScene("Words");
    }
}
