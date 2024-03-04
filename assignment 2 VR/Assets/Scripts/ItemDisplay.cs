using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    public Text messageText;

    public void DisplayMessage(string message)
    {
        messageText.text = message;
        Debug.Log("");
    }

    public void ClearMessage()
    {
        messageText.text = "";
    }
}