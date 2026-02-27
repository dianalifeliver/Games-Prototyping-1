using UnityEngine;

public class Bullet : MonoBehaviour
{
 public Rigidbody RB; // Object’s Own rigidbody
 public float Speed = 10; // Speed we want it to have
 // Start is called once before the first execution of Update after the MonoBehaviour is created
 void Start()
 {
 RB.linearVelocity = transform.forward * Speed; // moving an object via a force, as opposed to transform.
 }
 public void OnCollisionEnter(Collision collision)
 {
 Destroy(gameObject);
 }
}
