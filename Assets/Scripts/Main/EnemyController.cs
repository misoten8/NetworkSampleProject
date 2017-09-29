using UnityEngine;

/// <summary>
/// EnemyController クラス
/// 製作者：実川
/// </summary>
public class EnemyController : BasePlayer
{
	/// <summary>
	/// 移動目標座標
	/// </summary>
	[SerializeField]
	private Transform goalPoint;

	void Update ()
	{
		Vector3 controlPoint = new Vector3(goalPoint.position.x, 0.0f, transform.position.z + 3.0f);
		Vector3 dir = Vector3.Normalize(controlPoint - new Vector3(transform.position.x, 0.0f, transform.position.z));
		rb.AddForce(dir * power);
	}
}
