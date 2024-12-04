using UnityEngine;

public class Player : MonoBehaviour
{
	
	Rigidbody rb;
	float xInput;
	public float speed;
	
	public float score=0;
	public float hp=3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
		Vector3 moveDirection = new Vector3(xInput,0,0).normalized;
		rb.linearVelocity = moveDirection*speed;
		
		//Debug.Log(hp);
    }
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag=="Enemy"){
			
			Destroy(collision.gameObject);
			score+=1;
		}
	}
	
	public void UpdateHP(){
		hp-=1;
	}
}
