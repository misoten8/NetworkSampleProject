using UnityEngine.Networking;

/// <summary>
/// Player クラス
/// 製作者：実川
/// </summary>
public class Player : NetworkBehaviour
{
	void Start ()
	{
		
	}
	
	void Update ()
	{
		//NetworkServer.Spawn( bullet );	
	}

	[Command]
	public void CmdHoge()
	{

	}
}
