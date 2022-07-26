using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager _gameManager;
    private int _enemyCount;
    [Range(0,5)][SerializeField] private float _gameSpeed = 1;
    private bool _gameOver;

    public bool GameOver {
        get => _gameOver;
        set => _gameOver = value;
    }
    public int EnemyCount{
        get => _enemyCount;
        set => _enemyCount = value;
    }

    public static GameManager Instance {
        get => _gameManager;
        set => _gameManager = value;
    }

    private void Awake() {
        Instance = this;
    }

    private void Update() {
        Time.timeScale = _gameSpeed;
    }
}
