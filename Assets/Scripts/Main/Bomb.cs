using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Bomb クラス
/// 製作者：実川
/// </summary>
public class Bomb : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
	{
		ParticleManager.Play("Exprosion", transform.position);
		Destroy(gameObject);
	}
}
