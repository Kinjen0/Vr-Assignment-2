using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int nextScene;
    // Start is called before the first frame update
    
    public void loadNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }    




}
