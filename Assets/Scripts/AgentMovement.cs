using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMovement : MonoBehaviour
{

	[SerializeField]
	protected NavMeshAgent agent;

	public NavMeshAgent Agent {
		get {
			return agent;
		}
	}

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButton (0)) {
			RaycastHit hit;
			if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit)) {
				Debug.DrawLine (Camera.main.transform.position, hit.point);
				if (agent != null) {
					agent.SetDestination (hit.point);
				}
			}
		}
	}
}
