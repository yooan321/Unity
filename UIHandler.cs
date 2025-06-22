using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;



public class UIHandle : MonoBehaviour
{
    public static UIHandle instance { get; private set; }
    private VisualElement m_Healthbar;
    private void Awake()
    {

        instance = this;  
    } 
    void Start()
    {
        UIDocument uIDocument = GetComponent<UIDocument>();
        m_Healthbar = uIDocument.rootVisualElement.Q<VisualElement>("HealthBar");
        SetHealthValue(1.0f);
    }
    public void SetHealthValue(float percentage)
    {
        m_Healthbar.style.width = Length.Percent(100 * percentage); 
    }
}