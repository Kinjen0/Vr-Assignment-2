using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    public Text messageText; //Text variable attached to UI for text in upper right

    public void DisplayMessage(string message)
    {
        messageText.text = message; //put message in upper right (from gaze over event)
        
    }

    public void ClearMessage()
    {
        messageText.text = ""; //Clears text in upper right (after hover using inspector)
    }
}