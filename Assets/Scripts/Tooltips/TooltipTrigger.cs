using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    #region Static Instance
    private static TooltipTrigger instance;
    public static TooltipTrigger Instance;
    #endregion

    private static LTDescr delay;
    public bool tooltipAvailable = false;
    public string header;

    [Multiline()]
    public string content;

    private void Awake()
    {
        #region Static Instance
        instance = this;
        #endregion
    }
   
    public void AddTooltip(string addedContent, string addedHeader = "")
    {
        this.gameObject.GetComponent<TooltipTrigger>().ChangeTooltip(addedContent, addedHeader);
        tooltipAvailable = true;
    }

    public void RemoveTooltip()
    {
        tooltipAvailable = false;
    }

    private void ChangeTooltip(string addedContent, string addedHeader = "")
    {
        header = addedHeader;
        content = addedContent;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (tooltipAvailable)
        {
            delay = LeanTween.delayedCall(0.5f, () =>
            {
                TooltipSystem.Show(content, header);
            });
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (tooltipAvailable)
        {
            LeanTween.cancel(delay.uniqueId);
            TooltipSystem.Hide();
        }
    }

    public void OnDisable()
    {
        if (tooltipAvailable)
        {
            try
            {
                LeanTween.cancel(delay.uniqueId); // Cancel the delay if there is one
            }
            finally
            {
                TooltipSystem.Hide();
            }
        }
    }
}
