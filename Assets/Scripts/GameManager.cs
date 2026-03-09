using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int totalRounds = 5;
    private int currentRound = 0;

    void Start()
    {
        StartNewRound();
    }

    public void StartNewRound()
    {
        currentRound++;
        Debug.Log("Starting Round " + currentRound);
        // Initialize round-specific logic here
    }

    public void EndCurrentRound()
    {
        Debug.Log("Ending Round " + currentRound);
        // Logic to end the current round and calculate results
        if (currentRound < totalRounds)
        {
            StartNewRound();
        }
        else
        {
            Debug.Log("Game Over! All rounds completed.");
        }
    }
}