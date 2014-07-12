using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	
	
	public float TeleportSpeed;
	public float Smooting;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		DoTeleport();
	}
	
	void DoTeleport()
	{
		if(Input.GetKey(KeyCode.Alpha1))
		{
			
			Vector3 endlocation =  CheckObjectInPlace();
			//if we find something, don't teleport
			//do something more interesting to notify the player they can't
			if(Vector3.Equals(endlocation,transform.position))
			{
				Debug.Log("You can't teleport there");
				return;
			}
			
			Debug.Log("the endlocation is " + endlocation.ToString());
	
			transform.position = Vector3.Lerp(transform.position, endlocation, TeleportSpeed * Smooting * Time.deltaTime);
		}
	}
	
	
	//checks if the player targets an area that she cannot teleprt into, I.E., on an object
	Vector3 CheckObjectInPlace()
	{
		Ray checker = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if(Physics.Raycast(checker, out hit))
		{
			Debug.Log("We hit something at " + hit.point.ToString());
			
			//for now, return false if we hit the backdrop.
			//update when objects are resolved.
			if(hit.collider.tag == "BackGround")
				return hit.point;
			
		}
		
		return transform.position;
	}
}
