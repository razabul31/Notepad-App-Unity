using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoad : MonoBehaviour
{
    public string theText;
    public GameObject ourNote;
    public GameObject placeHolder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void saveNote()
    {
        theText = ourNote.GetComponent<Text>().text;
    }

}
