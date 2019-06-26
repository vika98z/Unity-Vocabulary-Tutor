using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordsScript : MonoBehaviour
{
    public TextAsset file;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.GetComponentInChildren<Text>().text = StaticScript.fileName;
        if (StaticScript.fileName.Length > 16)
            panel.GetComponentInChildren<Text>().fontSize = 9;
    }
}
