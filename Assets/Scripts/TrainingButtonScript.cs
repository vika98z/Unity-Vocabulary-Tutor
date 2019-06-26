using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class TrainingButtonScript : MonoBehaviour
{
    public Dropdown dropdown;
    public InputField input;
    public Transform Beginner;
    public Transform Elementary;
    public Transform Intermediate;
    public Transform Advanced;
    public Transform WordsPanel;
    public Font font;
    public Sprite Image;

    void Start()
    {
        if (input.text == "")
            input.onEndEdit.AddListener(delegate { ValueChangeCheck(); });
        else
            ValueChangeCheck();
    }

    void ValueChangeCheck()
    {
        if (Directory.Exists(input.text))
        {
            Debug.Log("Exists!!!");
            string dir = input.text;
            List<string> ListOfNames = new List<string> { };
            Directory.GetFiles(dir, "*", SearchOption.AllDirectories).ToList().ForEach(f => ListOfNames.Add(Path.GetFileName(f)));
            foreach (string str in ListOfNames)
            {
                string pattern = @"\d\.\d{1,3}\.(.+)\.txt$";
                Match match = Regex.Match(str, pattern);
                if (match.Success)
                {
                    string[] parts = str.Split('.'); //1.03.Люди. Внешность. Характер. (Describing people).txt
                    string name = ""; //текст на кнопке
                    for (int i = 2; i < parts.Length - 1; i++)
                        name += parts[i];
                    GameObject NewButton = new GameObject(parts[0] + parts[1], typeof(Image), typeof(Button), typeof(LayoutElement));
                    switch (parts[0])
                    {
                        case "1":
                            NewButton.transform.SetParent(Beginner);
                            break;
                        case "2":
                            NewButton.transform.SetParent(Elementary);
                            break;
                        case "3":
                            NewButton.transform.SetParent(Intermediate);
                            break;
                        case "4":
                            NewButton.transform.SetParent(Advanced);
                            break;
                    }
                    NewButton.GetComponent<LayoutElement>().minHeight = 35;
                    NewButton.GetComponent<LayoutElement>().minWidth = 275;
                    GameObject NewText = new GameObject(name, typeof(Text));
                    NewText.transform.SetParent(NewButton.transform);
                    NewText.GetComponent<Text>().text = name;
                    NewText.GetComponent<Text>().font = font;
                    RectTransform rt = NewText.GetComponent<RectTransform>();
                    rt.anchorMin = new Vector2(0, 0);
                    rt.anchorMax = new Vector2(1, 1);
                    rt.anchoredPosition = new Vector2(0, 0);
                    rt.sizeDelta = new Vector2(0, 0);
                    var rectTransform = NewButton.GetComponent<RectTransform>();
                    rectTransform.localScale = new Vector3(1, 1, 1);
                    NewButton.GetComponent<Image>().sprite = Image;
                    NewButton.GetComponent<Image>().type = UnityEngine.UI.Image.Type.Sliced;
                    rt.localScale = new Vector3(1, 1, 1);
                    NewText.GetComponent<Text>().color = Color.black;
                    NewText.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
                    NewButton.GetComponent<Button>().onClick.AddListener(delegate { WordsPanel.gameObject.SetActive(true); });
                }
            }
        }
    }
}
