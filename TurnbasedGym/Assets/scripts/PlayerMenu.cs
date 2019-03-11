using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMenu : MonoBehaviour
{
    public TacticsMove currentPlayer;
    public Character currentCharacter;

    public Button playerMoveButton;
    public Button endTurnButton;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPlayer(TacticsMove player, Character character)
    {
        currentPlayer = player;
        currentCharacter = character;

        playerMoveButton.onClick.AddListener(delegate { currentPlayer.BeginMoveSelection(); DisablePlayerMenu(); });
        endTurnButton.onClick.AddListener(delegate { EndTurn(); DisablePlayerMenu(); });

        DisableButtons();
    }

    void DisableButtons()
    {
        playerMoveButton.enabled = !currentCharacter.hasMoved;
    }

    public void DisablePlayerMenu()
    {
        gameObject.SetActive(false);
    }

    public void EndTurn()
    {
        currentPlayer.EndTurn();
    }
}
