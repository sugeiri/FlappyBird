using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class VentanaAlerta : MonoBehaviour
{
   // public Button confimacion;
    //public Button cancel;

    private System.Action storedActionOnConfirm;
    private static VentanaAlerta instance;
    public TextMeshProUGUI dialogText;


    public static void Show(string dialogMessage, System.Action actionOnConfirm)
    {
        instance.storedActionOnConfirm = actionOnConfirm;
        instance.dialogText.text = dialogMessage;
        instance.gameObject.SetActive(true);
    }
    
    void Awake()
    {
        instance = this;
        gameObject.SetActive(false);
    }
    public void OnConfirmButton()
    {
        if (storedActionOnConfirm != null)
        {
            storedActionOnConfirm();
            storedActionOnConfirm = null;
            gameObject.SetActive(false);
        }
    }
    public void OnCancelButton()
    {
        storedActionOnConfirm = null;
        gameObject.SetActive(false);
    }
}
