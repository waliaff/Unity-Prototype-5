using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtons : MonoBehaviour
{
    private Button button;
    public int difficulty;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Setdifficulty);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Setdifficulty()
    {
        Debug.Log(button.gameObject.name + " was clicked.");
        gameManager.StartGame(difficulty);
    }
}
