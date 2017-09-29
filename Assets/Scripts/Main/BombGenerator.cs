using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// BombGenerator クラス
/// 製作者：実川
/// </summary>
public class BombGenerator : MonoBehaviour
{
	[SerializeField]
	private FrontLine foreFront;

	/// <summary>
	/// 爆弾のプレハブ
	/// </summary>
	[SerializeField]
	private GameObject bombPrefab;

	/// <summary>
	/// 爆弾の生成間隔
	/// </summary>
	[SerializeField]
	private float interval;

	[SerializeField]
	private Vector3 offset;

	[SerializeField]
	private Vector2 rangeSize;

	public bool IsCreate
	{
		get { return isCreate; }
		set
		{
			if(value)
			{
				StartCoroutine(FuncCoroutine());
			}
			isCreate = value;
		}
	}

	/// <summary>
	/// 生成フラグ
	/// </summary>
	[SerializeField]
	private bool isCreate = true;

	void Start ()
	{
		IsCreate = true;
	}
	
	/// <summary>
	/// 爆弾を生成する
	/// </summary>
	private void Create()
	{
		Instantiate(bombPrefab).transform.position = foreFront.GetForeFront() + offset + new Vector3(Random.Range(-rangeSize.x, rangeSize.x), 0, Random.Range(-rangeSize.y, rangeSize.y));
	}

	IEnumerator FuncCoroutine()
	{
		do
		{
			yield return new WaitForSeconds(interval);
			Create();
		}
		while (isCreate);
	}
}
