using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class CanvasManager : MonoSingletonGeneric<CanvasManager>
{
    private List<CanvasUI> canvasUIs;
    private CanvasUI lastCanvas;
    new void Awake()
    {
        base.Awake();
        canvasUIs = (GetComponentsInChildren<CanvasUI>()).ToList();
        canvasUIs.ForEach(x=>x.gameObject.SetActive(false));
        SwitchUI(CanvasType.Battle);
      
    }

    public void SwitchUI(CanvasType deriredType)
    {
        if (lastCanvas != null)
        {
            lastCanvas.gameObject.SetActive(false);
        }

        CanvasUI newCanvas = canvasUIs.Find(x => x.Type == deriredType);
        if (newCanvas != null)
        {
            newCanvas.gameObject.SetActive(true);
            lastCanvas = newCanvas;
        }
    }

   
}
