using UnityEngine;
using System.Collections;

public class DoorOpen : MonoBehaviour {
	
	private Animation DoorAnim;
	private bool open = false;

	// Use this for initialization
	void Start () {
		
	DoorAnim = GetComponent<Animation>();
	
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
