using UnityEngine;

public class ShowBookContent : MonoBehaviour
{
    [SerializeField] private GameObject bookContent;
    [SerializeField] private Animator contentAnimator;
    private bool bookOpen = false;
    
    void Start()
    {
        bookContent.SetActive(false);
    }

    public void ShowContentBook()
    {
        bookContent.SetActive(true);
        bookOpen = true;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C) && bookOpen)
        {
            bookContent.SetActive(false);
            bookOpen = false;
            contentAnimator.SetTrigger("Close Content");
        }
    }
}
