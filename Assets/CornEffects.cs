using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornEffects : MonoBehaviour
{
    // Start is called before the first frame update
    public int cornCount = 1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerStats>().CornCounter(cornCount);
            gameObject.SetActive(false);
        }
    }
}
