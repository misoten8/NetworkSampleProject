using UnityEngine;

/// <summary>
/// PlayerController クラス
/// 製作者：実川
/// </summary>
public class PlayerController : BasePlayer
{
	void Update ()
	{
		if (Input.GetKey("up")) rb.AddForce(Vector3.forward * power);
		if (Input.GetKey("left")) rb.AddForce(Vector3.left * power);
		if (Input.GetKey("right")) rb.AddForce(Vector3.right * power);
		if (Input.GetKey("down")) rb.AddForce(Vector3.back * power);

		//if (Input.GetKeyDown("j")) rb.AddForce(Vector3.up * 10.0f, ForceMode.Impulse);
	}
}
