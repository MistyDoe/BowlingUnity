using UnityEngine;

public class BowlingBall : MonoBehaviour
{
	public float forwardForce;
	public float rightBoarder;
	public float leftBoarder;
	public float movementIncrement;
	public Rigidbody rig;


	private void Start()
	{
		Bowl();
	}

	void Bowl()
	{
		rig.AddForce(transform.forward * forwardForce);
	}
}
