using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    public Text messageText;

    public void DisplayMessage(string message)
    {
        messageText.text = message;
        Debug.Log("first message");
    }

    public void ClearMessage()
    {
        messageText.text = "";
    }
}