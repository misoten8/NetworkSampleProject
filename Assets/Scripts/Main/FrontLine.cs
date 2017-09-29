using UnityEngine;
using System.Linq;
using Misoten8Util;

/// <summary>
/// 先頭のプレイヤーの情報を取得するクラス
/// 製作者：実川
/// </summary>
public class FrontLine : MonoBehaviour
{
	// 取得の仕組みはいずれ変更する
	private Transform[] playerArray;

	private int firstPlayerInstanceID = -1;

	private void Start()
	{
		playerArray = GameObject.FindGameObjectsWithTag("Player").Select(x => x.transform).ToArray();
	}

	private void Update()
	{
		Transform target = playerArray.FindMax(x => x.position.z);
		firstPlayerInstanceID = target.gameObject.GetInstanceID();
		transform.position = new Vector3(transform.position.x, transform.position.y, target.position.z);
	}

	public Vector3 GetForeFront()
	{
		return transform.position;
	}

	public GameObject GetFirstPlayer()
	{
		return playerArray.FindMax(x => x.position.z).gameObject;
	}

	public bool IsFirstPlayer(int instanceID)
	{
		if (firstPlayerInstanceID == instanceID) return true;
		return false;
	}
}
