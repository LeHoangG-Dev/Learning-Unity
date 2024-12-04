using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
	public Button newGame;
	public Button Exit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (newGame!=null){
			newGame.onClick.AddListener(StartGame);
			Exit.onClick.AddListener(Quit);
		}
    }
	
	void StartGame(){
		
		SceneManager.LoadScene("SampleScene");
	}
	void Quit(){
		
		Application.Quit();
		
	}

 
}
