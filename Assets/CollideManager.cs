using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.currItem++;
            gameObject.SetActive(false);
            if(GameManager.Instance.currItem == GameManager.Instance.maxItem)
            {
                string currentScene = SceneManager.GetActiveScene().name;
                int currentLevelNumber = int.Parse(Regex.Match(currentScene, @"\d+").Value);
                string nextSceneName = "Level " + (currentLevelNumber + 1);
                GameManager.Instance.ChangeScene(nextSceneName);
            }
        }
    }
}
