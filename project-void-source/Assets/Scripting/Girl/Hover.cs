using UnityEngine;
using System.Collections;

public class Hover : MonoBehaviour {
	
	/// <summary>
	/// The hover time before an object must be dropped
	/// </summary>
	public int hoverTime;
	
	/// <summary>
	/// The height of the hover off of the ground
	/// </summary>
	public int hoverHeight;
	
	/// <summary>
	/// The max range this ability can be cast from 
	/// </summary>
	public int maxRange;
	
	/// <summary>
	/// The speed at which the box should float.
	/// </summary>
	public float liftSpeed;
	
	/// <summary>
	/// This should be switched on if the girl is levitating an object.
	/// </summary>
	public bool isLevitating;
	
	/// <summary>
	/// The object currently under hover control.
	/// NULL if none;
	/// </summary>
	public GameObject hoveringObject;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	/// <summary>
	/// Design:
	/// Check if she is already hovering an object, if so, cancel
	/// if she is not, then capture the object under the cursor of the mouse
	/// Set the hoveringObject that that object
	/// apply a constant force under that object until time is out
	/// clear the object, set isLevitating to false
	/// Rinse and repeat for future use
	/// </summary>
}
