using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    private Button button;
    [SerializeField]
    private CanvasType canvasType;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(delegate { CanvasManager.Instance.SwitchUI(canvasType); });
    }

    
}
