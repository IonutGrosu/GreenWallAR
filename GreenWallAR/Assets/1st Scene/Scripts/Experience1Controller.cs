using System;
using UnityEngine;

public class Experience1Controller : MonoBehaviour
{
    private int chapter = 1;
    // ch 1 - qr code border and Start button. Click on start => ch 2
    // ch 2 - room, info text panel and Next button. Click on next => ch 3
    // ch 3 - transparent room, focus on pipes. 
    
    [SerializeField] private GameObject walls;
    [SerializeField] private GameObject room;
    [SerializeField] private GameObject qrCodeBorder;
    [SerializeField] private GameObject startBtn;
    [SerializeField] private GameObject nextBtn;
    [SerializeField] private GameObject openInfoPanelBtn;

    [SerializeField] private Material wallsMaterialOpaque;
    [SerializeField] private Material wallsMaterialTransparent;

    void Start()
    {
        room.SetActive(false);
        nextBtn.SetActive(false);
        openInfoPanelBtn.SetActive(false);
    }

    private void Update()
    {
        if (chapter == 1)
        {
         room.SetActive(false);
         nextBtn.SetActive(false);
         openInfoPanelBtn.SetActive(false);
        } else if (chapter == 2)
        {
            startBtn.SetActive(false);
            openInfoPanelBtn.SetActive(true);
            nextBtn.SetActive(true);
            room.SetActive(true);
            qrCodeBorder.SetActive(false);
        } else if (chapter == 3)
        {
            MakeWallsInvisible();
        }
    }

    public void NextChapter()
    {
        chapter++;
    }

    public void MakeWallsInvisible()
    {
        walls.GetComponent<Renderer>().material = wallsMaterialTransparent;
    }
}
