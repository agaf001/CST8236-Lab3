using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

    public ParticleSystem dust;
    public Rigidbody rb;

    void Start () {
	    rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {


    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag != "Sphere")
            return;

        float power = 50.0F;
        float radius = 100.0F;

        rb.isKinematic = false;
        Vector3 explosionPos;
        explosionPos.y = 0;
        explosionPos.x = 0;
        explosionPos.z = 0;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {


            if (rb != null)
            {
                rb.AddExplosionForce(power, explosionPos, radius, 1);
            }

        }
    }
}
