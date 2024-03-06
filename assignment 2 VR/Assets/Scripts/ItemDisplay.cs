using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    public Text messageText;

    public void DisplayMessage(string message)
    {
        messageText.text = message;
        
    }

    public void ClearMessage()
    {
        messageText.text = "";
    }
}