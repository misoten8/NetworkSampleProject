using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// SceneObjectManager クラス
/// 製作者：実川
/// </summary>
public class SceneObjectManager : SingletonMonoBehaviour<SceneObjectManager>
{
	/// <summary>
	/// SceneObjectとSceneの紐付けマップ
	/// </summary>
	//private readonly Dictionary<ISceneObject, Define.SceneType> SCENE_OBJECT_MAP = new Dictionary<ISceneObject, Define.SceneType>
	//{

	//};


	public static void CreateAll(Define.SceneType sceneType)
	{
		// グローバルオブジェクト生成

		// ローカルオブジェクト生成
	}

	public static void DeleteAll(Define.SceneType sceneType)
	{
		// ローカルオブジェクト消去

		// グローバルオブジェクト消去
	}

	public static void FindAll(Define.SceneType sceneType)
	{
		
	}
}
