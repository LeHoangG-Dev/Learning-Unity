using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float hp;
    public float score;

    public TextMeshProUGUI hp_Text;
    public TextMeshProUGUI score_Text;
    public TextMeshProUGUI lose_Text;

    public GameObject quit;

    private Player player;

    void Start()
    {
	
	
        player = FindFirstObjectByType<Player>(); // Ensure we find the player object
        if (player == null)
        {
            Debug.LogError("Player object not found in the scene!");
        }
    }

    void Update()
    {
        if (player != null)
        {
            score = player.score;
            hp = player.hp;
            UpdateUI();
        }
    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void UpdateUI()
    {
        if (score_Text != null)
        {
            score_Text.text = $"Score: {score}";
        }
       

        if (hp_Text != null)
        {
            hp_Text.text = $"HP: {hp}";
        }
       

        if (hp <= 0)
        {
            if (lose_Text != null)
            {
                lose_Text.text = "You Died!";
            }
          

			Time.timeScale = 0f;

         
          

            if (quit != null)
            {
                quit.SetActive(true);
            }
            

            DeadMenu();
        }
    }

    void DeadMenu()
    {
     
       

        if (quit != null && quit.GetComponent<Button>() != null)
        {
            quit.GetComponent<Button>().onClick.AddListener(QuitGame);
        }
      
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
