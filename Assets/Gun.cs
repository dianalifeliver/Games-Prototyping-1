using UnityEngine;

public class Gun: MonoBehaviour
{
 public Bullet BulletPrefab;
 public Transform spawnPoint;
 // Update is called once per frame
 void Update()
 {
 if (Input.GetMouseButton(0)) //We’ve discussed Inputs. Why is this not OnMouseDown Method?
 {
 Instantiate(BulletPrefab, spawnPoint.position, spawnPoint.rotation);
// instruction to instatiate. Needs What, Where, and How to rotate.
 }
 }
}