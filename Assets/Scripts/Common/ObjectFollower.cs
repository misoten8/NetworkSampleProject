using UnityEngine;

public class ObjectFollower : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;

	void Start()
	{
		offset = transform.position;
	}

	void Update ()
    {
        if (target == null) return;
		transform.position = target.position + offset;
	}
}
