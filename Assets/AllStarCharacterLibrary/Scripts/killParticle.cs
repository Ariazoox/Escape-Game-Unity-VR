using UnityEngine;
using System.Collections;

public class killParticle : MonoBehaviour 
{
	ParticleSystem ps;
	public float lifespan;
	float startTime;

	// Use this for initialization
	void Start () 
	{
		ps = GetComponent<ParticleSystem>();
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if((Time.time - startTime) > lifespan)
		{
			Destroy(gameObject);
		}
	}
}