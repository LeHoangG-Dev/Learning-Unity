using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static TimeManager Instance; // Singleton
	public float downSpeed;
	void Awake(){
		
		if (Instance==null){
			Instance=this;
			DontDestroyOnLoad(gameObject);
		}
		else{
			Destroy(gameObject);
			
		}
		
	}
	

    // Update is called once per frame
    void Update()
    {
        downSpeed = downSpeed + 0.001f;
    }
}
