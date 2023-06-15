using UnityEngine;

public class Experience1Controller : MonoBehaviour
{
    private int chapter = 1;
    // ch 1 - qr code border and Start button. Click on start => ch 2
    // ch 2 - room, info text panel and Next button. Click on next => ch 3
    // ch 3 - transparent room, focus on pipes. 
    
    [SerializeField] private GameObject walls;
    [SerializeField] private GameObject ceiling;
    [SerializeField] private GameObject floor;
    [SerializeField] private GameObject room;
    [SerializeField] private GameObject qrCodeBorder;
    [SerializeField] private GameObject startBtn;
    [SerializeField] private GameObject nextBtn;
    [SerializeField] private GameObject endBtn;
    [SerializeField] private GameObject openInfoPanelBtn;
    [SerializeField] private GameObject endPanel;

    [SerializeField] private Material wallsMaterialOpaque;
    [SerializeField] private Material wallsMaterialTransparent;
    [SerializeField] private Material ceilingMaterialOpaque;
    [SerializeField] private Material ceilingMaterialTransparent;
    [SerializeField] private Material floorMaterialOpaque;
    [SerializeField] private Material floorMaterialTransparent;
    
    private GameObject _arSessionOrigin;

    void Start()
    {
        _arSessionOrigin = GameObject.Find("AR Session Origin");

        room.SetActive(false);
        nextBtn.SetActive(false);
        openInfoPanelBtn.SetActive(true);
        endPanel.SetActive(false);
        endBtn.SetActive(false);
    }

    private void Update()
    {
        if (chapter == 1)
        {
         room.SetActive(false);
         nextBtn.SetActive(false);
         // openInfoPanelBtn.SetActive(false);
         endPanel.SetActive(false);
        } else if (chapter == 2)
        {
            startBtn.SetActive(false);
            // openInfoPanelBtn.SetActive(true);
            nextBtn.SetActive(true);
            room.SetActive(true);
            qrCodeBorder.SetActive(false);
        } else if (chapter == 3)
        {
            MakeWallsInvisible();
        }
        else if(chapter == 4)
        {
            MakeWallsVisible();
            endPanel.SetActive(true);
            nextBtn.SetActive(false);
            // endBtn.SetActive(true);
            openInfoPanelBtn.SetActive(false);
            NextChapter();
        }
    }

    public void NextChapter()
    {
        chapter++;
    }

    public void MakeWallsInvisible()
    {
        walls.GetComponent<Renderer>().material = wallsMaterialTransparent;
        ceiling.GetComponent<Renderer>().material = ceilingMaterialTransparent;
        floor.GetComponent<Renderer>().material = floorMaterialTransparent;
    }
    
    public void MakeWallsVisible()
    {
        walls.GetComponent<Renderer>().material = wallsMaterialOpaque;
        ceiling.GetComponent<Renderer>().material = ceilingMaterialOpaque;
        floor.GetComponent<Renderer>().material = floorMaterialOpaque;
    }

    public void CloseEndPanel()
    {
        endPanel.SetActive(false);
        EndExperience();
    }

    public void EndExperience()
    {
        var parent = this.transform.parent.gameObject;
        _arSessionOrigin.GetComponent<PlaceTrackedImages>().RemoveTrackedExperience("experience1");

        Destroy(parent);
    }
}
