using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Experience2Controller : MonoBehaviour
{
    private int chapter = 1;

    [SerializeField] private GameObject go;
    [SerializeField] private GameObject qrCodeBorder;
    [SerializeField] private GameObject startBtn;
    [SerializeField] private GameObject nextBtn;
    [SerializeField] private GameObject openInfoPanelBtn;
    
    
    // Start is called before the first frame update
    void Start()
    {
        go.SetActive(false);
        nextBtn.SetActive(false);
        openInfoPanelBtn.SetActive(true);
    }

    private void Update()
    {
        if (chapter == 1)
        {
            go.SetActive(false);
            nextBtn.SetActive(false);
            // openInfoPanelBtn.SetActive(false);
        } else if (chapter == 2)
        {
            startBtn.SetActive(false);
            // openInfoPanelBtn.SetActive(true);
            nextBtn.SetActive(true);
            go.SetActive(true);
            qrCodeBorder.SetActive(false);
        }
    }

    public void NextChapter()
    {
        chapter++;
    }
}
