using UnityEngine;

public class ShowCameraDiagram : MonoBehaviour
{
    [SerializeField] private GameObject cameraDiagram;
    [SerializeField] private Animator diagramAnimator;
    private bool diagramOpen = false;

    void Start()
    {
        cameraDiagram.SetActive(false);
    } 

    public void ShowDiagramCamera()
    {
        cameraDiagram.SetActive(true);
        diagramOpen = true;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C) && diagramOpen)
        {
            cameraDiagram.SetActive(false);
            diagramOpen = false;
            diagramAnimator.SetTrigger("CloseDiagram");
        }
    }
}
