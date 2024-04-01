using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superman : MonoBehaviour
{
    public LayerMask badGuyLayer;

    public float punchForce = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        if (badGuyLayer == (badGuyLayer | (1 << collision.gameObject.layer)))
        {
            Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 direction = collision.collider.transform.position - transform.position;
                rb.AddForce(direction.normalized * punchForce, ForceMode.Impulse);
            }
        }
    }
}
