using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObservationsPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI observationsPanelText;
    [SerializeField] private TextMeshProUGUI pageCountText;
    [SerializeField] private GameObject nextPageButton;
    [SerializeField] private GameObject prevPageButton;
    int currentPage = 1;

    public void Update()
    {
        int totalPages = observationsPanelText.textInfo.pageCount;
        if (totalPages > 1)
        {
            pageCountText.text = currentPage.ToString() + "/" + totalPages.ToString();
            nextPageButton.SetActive(true);
            prevPageButton.SetActive(true);
        }
        else
        {
            pageCountText.text = "";
            nextPageButton.SetActive(false);
            prevPageButton.SetActive(false);
        }
    }
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

        if (currentPage != 1) // Check if there are more pages to switch to
        {
            currentPage--;
            observationsPanelText.pageToDisplay--;
        }
    }
}
