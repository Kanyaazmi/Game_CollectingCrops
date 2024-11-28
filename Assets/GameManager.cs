using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance;
    public int maxItem;
    public int currItem;


    private void Awake()
    {
        Instance = this;
        maxItem = 5;
    }

    void Start()
    {
       
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        currItem = 0;

        if (sceneName.Contains("Level"))
        {
            maxItem += 5;
        }
    }
}
