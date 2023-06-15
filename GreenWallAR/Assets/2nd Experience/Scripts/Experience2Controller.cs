using UnityEngine;

public class Experience2Controller : MonoBehaviour
{
    private int chapter = 1;

    [SerializeField] private GameObject go;
    [SerializeField] private GameObject qrCodeBorder;
    [SerializeField] private GameObject startBtn;
    [SerializeField] private GameObject nextBtn;
    [SerializeField] private GameObject openInfoPanelBtn;
    [SerializeField] private GameObject endPanel;
    [SerializeField] private GameObject mask;

    private GameObject _arSessionOrigin;


    // Start is called before the first frame update
    void Start()
    {
        _arSessionOrigin = GameObject.Find("AR Session Origin");

        go.SetActive(false);
        nextBtn.SetActive(false);
        openInfoPanelBtn.SetActive(true);
        endPanel.SetActive(false);
        mask.SetActive(false);
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
        } else if (chapter == 3)
        {
            mask.SetActive(true);
        } else if (chapter == 4)
        {
            openInfoPanelBtn.SetActive(false);
            nextBtn.SetActive(false);
            endPanel.SetActive(true);
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
        _arSessionOrigin.GetComponent<PlaceTrackedImages>().RemoveTrackedExperience("experience2");

        Destroy(parent);
    }
}
