using UnityEngine;

public class Enemy : MonoBehaviour
{
	float downSpeed;
	private Player player;

    void Update()
    {
		downSpeed = TimeManager.Instance.downSpeed;
        Vector3 downDirection = new Vector3(0,-0.5f,0);
		transform.position = transform.position + downDirection*downSpeed*Time.deltaTime;
    }
	void OnCollisionEnter(Collision other)
    {
        // Kiểm tra nếu đối tượng va chạm có tag là "Ground"
		if(other.gameObject.tag=="Plane"){
			
			Destroy(gameObject);
			Player player = FindFirstObjectByType<Player>();
			player.UpdateHP();
			
			
		}
    }
}
