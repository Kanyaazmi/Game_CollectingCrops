using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    // Start is called before the first frame update
    public int corn = 0;
    public int tomato = 0;
    public int hits = 0;
    public int maxHits = 5;
    public TextMeshProUGUI cornText, tomatoText, hitText;
    public static PlayerStats instance;
    void Start()
    {
        cornText.text = "Corn: " + corn;
        tomatoText.text = "Tomato: " + tomato;
        hitText.text = "Hits: " + hits + "/" + maxHits;
        instance = this;
    }

    public void CornCounter(int amount)
    {
        corn += amount;
        cornText.text = "Corn: " + corn.ToString();

    }

    public void TomatoCounter(int amount)
    {
        tomato += amount;
        tomatoText.text = "Tomato: " + tomato.ToString();

    }

    public void HitCounter(int amount)
    {
        hits += amount;
        hitText.text = "Hits: " + hits + "/" + maxHits;

        if (hits >= maxHits)
        {
            GameManager.Instance.ChangeScene("Game Over");
        }
    }
}
