using UnityEngine;

public class Vector3Data : MonoBehaviour
{
	public static Vector3 negativInfinity;
	Vector3 position;
	Rigidbody enemy;
	float enSpeed = 1.0f;

	void Start()
	{
		position = new Vector3(0.0f, 1.0f, 1.0f);
		enemy = GetComponent<Rigidbody>();
	}

	void Update()
	{
		enemy.velocity = position * enSpeed;
	}
}