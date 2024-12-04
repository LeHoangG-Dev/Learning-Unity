using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public GameObject enemyDown;
	public float spawnInterval =1f;
	public float spawnRange=6f;
	public float timeLastSpawn=0f;


    // Update is called once per frame
    void Update()
    {
        timeLastSpawn=timeLastSpawn+Time.deltaTime;
		if (timeLastSpawn>spawnInterval){
			
			SpawnEnemy();
			timeLastSpawn=0f;
			
			
		}
		
    }
	void SpawnEnemy(){
		
		float SpawnX = Random.Range(-spawnRange/2,spawnRange/2);
		Vector3 spawnPosition = new Vector3(SpawnX,transform.position.y,transform.position.z);
		Instantiate(enemyDown,spawnPosition,Quaternion.identity);
		
		
		
	}
}
