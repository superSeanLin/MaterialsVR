﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Microsoft.MixedReality.Toolkit.Input;

public class Back_Handler : MonoBehaviour, IMixedRealityPointerHandler
{
    private GameObject MR;
    private GameObject UI;

    /*
    [SerializeField]
    private TestButton button = null;

    private void Awake()
    {
        button.Activated += OnButtonPressed;
    }

    

    private void OnButtonPressed(TestButton data) { 
        // if clicked at button
        // if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() != null)
        SceneManager.LoadScene("New_Menu");
        
    }

    */


    private void Start()
    {
        MR = GameObject.Find("Microsoft Camera and Input Rig");
        UI = GameObject.Find("UIManager MR");
    }

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        // if clicked at button
        // if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>() != null)
        SceneManager.LoadScene("New_Menu_without_MR_Rig");
        //Destroy(MR);
        //Destroy(UI);
    }
    public void OnPointerDown(MixedRealityPointerEventData eventData) { }

    public void OnPointerDragged(MixedRealityPointerEventData eventData) { }

    public void OnPointerUp(MixedRealityPointerEventData eventData) { }
}
