using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int score;

    private void Awake()
    {
        Instance = this;
    }

    public void AddPoints(int value)
    {
        score += value;
    }
}

