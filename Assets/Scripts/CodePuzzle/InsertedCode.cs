using UnityEngine;

public class InsertedCode : MonoBehaviour
{
    public int[] codeNumbers = new int[3];
    Interactive interactive;

    void Start()
    {
        interactive = GetComponent<Interactive>();
    }

    void Update()
    {
        
    }

    public void InsertNumber(int codeNumber)
    {
        interactive.interactiveData.requirementsMessage += $"{codeNumber} ";
    }
}
