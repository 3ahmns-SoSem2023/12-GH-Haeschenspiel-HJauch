using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WuerfelScript : MonoBehaviour
{

    public Color[] wuerfelColors;
    public int score;
    public int currentColor;
    public Text scoreText;
    public GameObject win;
    public Button red;
    public Button white;
    public Button blue;
    public Button yellow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 10)
        {
            win.SetActive(true);
            Invoke("LoadStart", 3);
            red.interactable = false;
            blue.interactable = false;
            yellow.interactable = false;
            white.interactable = false;
        }
    }

    public void Wuerfel()
    {
        int Index = Random.Range(0, wuerfelColors.Length);
        if (Index == currentColor)
        {
            score++;
        }

        if (Index == 5)
        {
            score += 2;
        }

        if (Index == 0 && score > 0)
        {
            score -= 1;
        }

        scoreText.text = score.ToString();
        gameObject.GetComponent<Image>().color = wuerfelColors[Index];
            
    }

    public void LoadStart()
    {
        SceneManager.LoadScene("StartScene");
    }

}
