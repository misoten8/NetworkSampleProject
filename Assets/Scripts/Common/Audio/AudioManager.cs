using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// オーディオ管理クラス
/// 製作者：実川
/// </summary>
public class AudioManager : SingletonMonoBehaviour<AudioManager>
{
	[SerializeField]
	private GameObject _bgmPrefab;
	[SerializeField]
	private GameObject _sePrefab;

	/// <summary>
	/// サウンドのAudioClipキャッシュリスト
	/// </summary>
	List<AudioClip> _seCacheList = new List<AudioClip>();

	void Start()
	{
		Load();
	}

	/// <summary>
	/// 使用するオーディオを事前に読み込む
	/// </summary>
	public static void Load()
	{
		// サウンドは事前に読み込んでキャッシュする
		if (Instance._seCacheList.Count > 0) return;
		foreach (AudioClip audioClip in Resources.LoadAll<AudioClip>(Define.SE_ASSET_DIRECTORY))
		{
			Instance._seCacheList.Add(audioClip);
		}
	}

	/// <summary>
	/// BGMを再生
	/// </summary>
	/// <param name="fileName">ファイル名</param>
	public static void PlayBGM(string fileName)
	{
		GameObject obj = Instantiate(Instance._bgmPrefab, Instance.transform);
		obj.name = "BGM_" + fileName;
		AudioSource audioSource = obj.GetComponent<AudioSource>();
		audioSource.clip = Resources.Load<AudioClip>(Define.BGM_ASSET_DIRECTORY + fileName);
		audioSource.volume = 0.5f;
		if (audioSource.clip == null)
		{
			Debug.LogWarning("指定された名前のオーディオファイルが見つかりませんでした　ファイル名：" + fileName);
			Destroy(obj);
			return;
		}
		audioSource.Play();
	}

	/// <summary>
	/// SEを再生
	/// </summary>
	/// <param name="fileName">ファイル名</param>
	public static void PlaySE(string fileName)
	{
		GameObject obj = Instantiate(Instance._sePrefab, Instance.transform);
		obj.name = "SE_" + fileName;
		AudioSource audioSource = obj.GetComponent<AudioSource>();
		audioSource.clip = Instance._seCacheList.Where(e => e.name == fileName).FirstOrDefault();
		audioSource.volume = 1.0f;
		if (audioSource.clip == null)
		{
			Debug.LogWarning("指定された名前のオーディオファイルが見つかりませんでした　ファイル名：" + fileName);
			Destroy(obj);
			return;
		}
		audioSource.Play();
	}

	/// <summary>
	/// BGMの再生中断
	/// </summary>
	public static void PauseBGM()
	{
		UniqueAudioController.Pause();
	}

	/// <summary>
	/// BGMの再生続行
	/// </summary>
	public static void ContinueBGM()
	{
		UniqueAudioController.Continue();
	}

	/// <summary>
	/// BGMを最初から再生する
	/// </summary>
	public static void RePlayBGM()
	{
		UniqueAudioController.RePlay();
	}

	/// <summary>
	/// BGMの音量を調整する
	/// </summary>
	/// <param name="volume">音量</param>
	public static void SetVolumeBGM(float volume)
	{
		UniqueAudioController.SetVolume(volume);
	}
}
