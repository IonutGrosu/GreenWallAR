using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] public RectTransform infoUI;
    [SerializeField] public Button openInfoPanelButton;
    [SerializeField] public Button closeInfoPanelButton;

    private bool showInfoPanel = false;
    
    public void ToggleInfoPanel()
    {
        showInfoPanel = !showInfoPanel;
        if (showInfoPanel)
        {
            openInfoPanelButton.gameObject.SetActive(false);
            closeInfoPanelButton.gameObject.SetActive(true);
            OpenInfoPanel();
        }
        else
        {
            openInfoPanelButton.gameObject.SetActive(true);
            closeInfoPanelButton.gameObject.SetActive(false);
            CloseInfoPanel();
        }
    }
    
    public void OpenInfoPanel()
    {
        infoUI.DOAnchorPos(Vector2.zero, 1f);
    }

    public void CloseInfoPanel()
    {
        infoUI.DOAnchorPos(new Vector2(0, -2000), 1f);
    }
}
