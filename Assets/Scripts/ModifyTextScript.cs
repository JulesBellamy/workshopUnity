using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModifyTextScript : MonoBehaviour
{
    public void ModifyText()
    {
        GameObject text = GameObject.Find("Text (TMP)");
        TextMeshProUGUI tm = text.GetComponent<TextMeshProUGUI>();
        tm.text = "Hello There !";
    }
}
