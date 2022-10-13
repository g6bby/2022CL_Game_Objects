using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetBtnActive : MonoBehaviour
{
    private Image redBtnOn;
    private Image redBtnOff;
    private Image redBtn;
    private Button btn;

    // Start is called before the first frame update
    void Start()
    {
        redBtnOn = GameObject.FindGameObjectWithTag("RedButton1").GetComponent<Image>();
        redBtnOff = GameObject.FindGameObjectWithTag("RedButton2").GetComponent<Image>();
        redBtn = GameObject.FindGameObjectWithTag("RedButton").GetComponent<Image>();

    }

    // Update is called once per frame
    public void BtnOn()
      {
        redBtnOn.enabled = true;
        redBtnOff.enabled = false;
    }

    public void BtnOff()
    {
        if (Input.GetMouseButtonDown(0))
        {
            redBtnOn.enabled = false;
            redBtnOff.enabled = true;
            redBtn.enabled = false;
        }
        else
        {
            redBtnOn.enabled = true;
            redBtnOff.enabled = false;
            redBtn.enabled = true;
        }
        
    }
}