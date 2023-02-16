using UnityEngine;

public class BowlingBall : MonoBehaviour
{
	public float forwardForce;
	public float rightBoarder;
	public float leftBoarder;
	public float movementIncrement;
	public Rigidbody rig;


	public void Bowl()
	{
		rig.AddForce(transform.forward * forwardForce, ForceMode.Impulse);
	}

	public void MoveLeft()
	{
		if (transform.position.x > leftBoarder)
		{
			transform.position += new Vector3(-movementIncrement, 0, 0);
		}
	}
	public void MoveRight()
	{
		if (transform.position.x < rightBoarder)
		{
			transform.position += new Vector3(+movementIncrement, 0, 0);
		}
	}

}
