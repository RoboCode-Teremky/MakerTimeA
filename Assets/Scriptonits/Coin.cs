using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Coin : MonoBehaviour
{
  public static UnityEvent pickCoin = new UnityEvent();
    // Start is called before the first frame update
   private void OnCollisionEnter2D(Collision2D other){
    if(other.collider.CompareTag("Player")){
    pickCoin.Invoke();
    Destroy(gameObject);
    }
   }
}
