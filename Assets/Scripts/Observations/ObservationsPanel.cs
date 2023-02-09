using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObservationsPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI observationsPanelText;
    int currentPage = 1;
    public void OnClick_NextPage()
    {
        int totalPages = observationsPanelText.textInfo.pageCount;

        if (currentPage < totalPages) // Check if there are more pages to switch to
        {
            currentPage++;
            observationsPanelText.pageToDisplay++;
        }
    }

    public void OnClick_PrevPage()
    {
        int totalPages = observationsPanelText.textInfo.pageCount;

        if (currentPage < totalPages) // Check if there are more pages to switch to
        {
            currentPage--;
            observationsPanelText.pageToDisplay--;
        }
    }
}
