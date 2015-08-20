using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody))]
public class Thrust : MonoBehaviour {



	private static float m_thrustForce = 20F;
	private static int m_thrustTimer = 200000;
	private static bool m_thrustActivated = false;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		activateThrust();
	}

	void activateThrust()
	{
		if (Input.GetKeyDown (KeyCode.F)) {
			m_thrustActivated = true;
		}


	}

	void FixedUpdate()
	{


			if(m_thrustActivated)
			{

				Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
				rb.AddForce(transform.forward*m_thrustForce);
				
				if(m_thrustTimer > 0)
				{m_thrustTimer-=1*(int)Time.deltaTime; } 
				else 
				{
					m_thrustActivated = false;
					m_thrustTimer = 200000;
				
				}
				
			
			} 
			
			


	}

}

