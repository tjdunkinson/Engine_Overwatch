using UnityEngine;
using System.Collections;

public class DoorOpen : MonoBehaviour {
	
	private Animation DoorAnim;
	private AnimationState DoorState;
	private bool open;

	// Use this for initialization
	void Start () {
		
	DoorAnim = GetComponent<Animation>();
	//DoorState = DoorAnim.GetComponent<AnimationState>();
	
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown ()
	{
		if (open == false)
		{
			DoorAnim.Play("DoorOpenAnim");
			open = true;
		}
		else
		{
			DoorAnim.Play("DoorCloseAnim");
			open = false;
			
		}
		
	}
}
