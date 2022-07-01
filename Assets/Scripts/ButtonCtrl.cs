using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonCtrl : MonoBehaviour
{
    public GameObject theText;
    public AudioSource clearSound;

    public void ClearTextField()
    {   
        theText.GetComponent<TMP_InputField>().text = "";
        clearSound.Play();
    } 
}
