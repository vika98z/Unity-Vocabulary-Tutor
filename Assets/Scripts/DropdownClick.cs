using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropdownClick : MonoBehaviour
{
    public Image Beginner;
    public Image Elementary;
    public Image Intermediate;
    public Image Advanced;
    public Dropdown dropdown;

    void Start()
    {
        dropdown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(dropdown);
        });
    }

    private void DropdownValueChanged(Dropdown dropdown)
    {
        Debug.Log($"{dropdown.value}: {dropdown.itemText}");
        int index = dropdown.value;
        switch (index)
        {
            case 0:
                //Beginner.transform.parent.gameObject.SetActive(true);
                //Elementary.transform.parent.gameObject.SetActive(false);
                Beginner.gameObject.SetActive(true);
                Elementary.gameObject.SetActive(false);
                Intermediate.gameObject.SetActive(false);
                Advanced.gameObject.SetActive(false);
                break;
            case 1:
                Elementary.gameObject.SetActive(true);
                Beginner.gameObject.SetActive(false);
                Intermediate.gameObject.SetActive(false);
                Advanced.gameObject.SetActive(false);
                break;
            case 2:
                Intermediate.gameObject.SetActive(true);
                Beginner.gameObject.SetActive(false);
                Elementary.gameObject.SetActive(false);
                Advanced.gameObject.SetActive(false);
                break;
            case 3:
                Advanced.gameObject.SetActive(true);
                Beginner.gameObject.SetActive(false);
                Elementary.gameObject.SetActive(false);
                Intermediate.gameObject.SetActive(false);
                break;
        }
    }
}
