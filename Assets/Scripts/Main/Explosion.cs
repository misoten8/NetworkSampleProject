using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Explosion クラス
/// 製作者：実川
/// </summary>
public class Explosion : MonoBehaviour
{
	[SerializeField]
	private float power;

	[SerializeField]
	private float lifeTime;

	[SerializeField]
	private SphereCollider sc;

	private void Update()
	{
		sc.radius += 0.015f;
		lifeTime -= Time.deltaTime;

		if (lifeTime > 0.0f) return;
		sc.enabled = false;
		enabled = false;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag != "Player") return;
		Vector3 dir = Vector3.Normalize(Vector3.up + Vector3.Normalize(other.transform.position - transform.position));
		other.GetComponent<Rigidbody>().AddForce(dir * power, ForceMode.Impulse);
	}
}
