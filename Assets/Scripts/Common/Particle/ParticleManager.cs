using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// パーティクル管理 クラス
/// 製作者：実川
/// </summary>
public class ParticleManager : SingletonMonoBehaviour<ParticleManager>
{
	/// <summary>
	/// パーティクルプレハブリスト
	/// </summary>
	[SerializeField]
	private GameObject[] _prefabArray = null;

	/// <summary>
	/// パーティクルインスタンスリスト
	/// </summary>
	private List<GameObject> _instanceList = new List<GameObject>();

	void Start()
	{
		Load();
	}

	/// <summary>
	/// 使用するパーティクルプレハブを事前読み込みを行う
	/// </summary>
	public static void Load()
	{
		Instance._prefabArray = Resources.LoadAll<GameObject>(Define.PARTICLE_ASSET_DIRECTORY);
	}

	/// <summary>
	/// パーティクルを再生する
	/// </summary>
	/// <param name="fileName">パーティクルプレハブ名</param>
	/// <param name="pos">座標</param>
	/// <param name="parent">親</param>
	public static GameObject Play(string fileName, Vector3 pos = new Vector3(), Transform parent = null)
	{
		foreach(GameObject element in Instance._prefabArray)
		{
			if (element.name != fileName) continue;

			GameObject instance;

			if(parent == null)
			{
				// ワールド座標
				instance = Instantiate(element);
				instance.transform.position = pos;
			}
			else
			{
				// 相対座標
				instance = Instantiate(element, parent);
				instance.transform.localPosition = pos;
			}

			Instance._instanceList.Add(instance);
			return instance;
		}
		return null;
	}

	/// <summary>
	/// 現在インスタンスされているパーティクルを全て消去します。
	/// </summary>
	public static void ResetAll()
	{
		if (Instance._instanceList.Count == 0) return;

		foreach(GameObject element in Instance._instanceList)
		{
			Destroy(element);
		}
		Instance._instanceList.Clear();
	}
}
