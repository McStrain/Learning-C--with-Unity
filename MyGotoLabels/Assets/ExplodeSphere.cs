using UnityEngine;
using System.Collections;

public class ExplodeSphere : MonoBehaviour {
	public float force;
	public float radius;

	void Update()
	{
		if(Input.GetMouseButton(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if(Physics.Raycast (ray, out hit, 100))
			{
				Collider[] colliders = Physics.OverlapSphere (hit.point, radius);

				foreach(Collider c in colliders)
				{
					if(c.rigidbody == null) continue;
					{
						c.rigidbody.AddExplosionForce(force, hit.point, radius, 1, ForceMode.Impulse);
					}
				}
			}
		}
	}
	void OnMouseDown()
	{
		rigidbody.AddForce (new Vector3(0,0, force), ForceMode.Impulse); 
	}

}

