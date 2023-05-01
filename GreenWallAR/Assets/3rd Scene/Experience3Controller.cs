using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experience3Controller : MonoBehaviour
{
    private int chapter = 1;
    // ch 1 - qr code border and Start button. Click on start => ch 2
    // ch 2 - pipes, info text panel and Next button. Click on next
    
    [SerializeField] private GameObject pipes;
    [SerializeField] private GameObject qrCodeBorder;
    [SerializeField] private GameObject startBtn;
    [SerializeField] private GameObject nextBtn;
    [SerializeField] private GameObject openInfoPanelBtn;

    // Start is called before the first frame update
    void Start()
    {
        pipes.SetActive(false);
        nextBtn.SetActive(false);
        openInfoPanelBtn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (chapter == 1)
        {
            pipes.SetActive(false);
            nextBtn.SetActive(false);
            // openInfoPanelBtn.SetActive(false);
        } else if (chapter == 2)
        {
            startBtn.SetActive(false);
            // openInfoPanelBtn.SetActive(true);
            nextBtn.SetActive(true);
            pipes.SetActive(true);
            qrCodeBorder.SetActive(false);
        }
    }
    
    public void NextChapter()
    {
        chapter++;
    }
}
