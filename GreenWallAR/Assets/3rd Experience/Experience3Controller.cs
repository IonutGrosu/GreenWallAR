using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experience3Controller : MonoBehaviour
{
    private int chapter = 1;
    // ch 1 - qr code border and Start button. Click on start => ch 2
    // ch 2 - pipes, info text panel and Next button. Click on next
    // ch 3 - no info button, no next button
    
    [SerializeField] private GameObject pipes;
    [SerializeField] private GameObject qrCodeBorder;
    [SerializeField] private GameObject startBtn;
    [SerializeField] private GameObject nextBtn;
    [SerializeField] private GameObject openInfoPanelBtn;
    [SerializeField] private GameObject endBtn;
    [SerializeField] private GameObject endPanel;

    private GameObject _arSessionOrigin;
    
    // Start is called before the first frame update
    void Start()
    {
        _arSessionOrigin = GameObject.Find("AR Session Origin");

        pipes.SetActive(false);
        nextBtn.SetActive(false);
        openInfoPanelBtn.SetActive(true);
        endPanel.SetActive(false);
        endBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (chapter == 1)
        {
            pipes.SetActive(false);
            nextBtn.SetActive(false);
            endPanel.SetActive(false);
            endBtn.SetActive(false);
            // openInfoPanelBtn.SetActive(false);
        } else if (chapter == 2)
        {
            startBtn.SetActive(false);
            // openInfoPanelBtn.SetActive(true);
            nextBtn.SetActive(true);
            pipes.SetActive(true);
            qrCodeBorder.SetActive(false);
        } else if (chapter == 3)
        {
            endPanel.SetActive(true);
            nextBtn.SetActive(false);
            openInfoPanelBtn.SetActive(false);
            endBtn.SetActive(false);
            NextChapter();
        }
    }
    
    public void NextChapter()
    {
        chapter++;
    }
    
    public void CloseEndPanel()
    {
        endPanel.SetActive(false);
        EndExperience();
    }
    
    public void EndExperience()
    {
        var parent = this.transform.parent.gameObject;
        _arSessionOrigin.GetComponent<PlaceTrackedImages>().RemoveTrackedExperience("experience3");

        Destroy(parent);
    }
}
