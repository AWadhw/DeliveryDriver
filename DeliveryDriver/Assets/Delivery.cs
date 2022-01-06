using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool PackagePicked; 
    [SerializeField] float DestroyDelay = 0.1f; 
    [SerializeField] Color32 HasPackageColor = new Color32(1,1,1,1); //start of with no tint
    [SerializeField] Color32 NoPackageColor = new Color32(1,1,1,1); //start of with no tint

    SpriteRenderer spriteRenderer; 

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>(); //    
    }
    private void OnCollisionEnter2D(Collision2D other) { //if we bump into something we can information for the thing we bumped into
        //don't need info for this object
        Debug.Log("Boink!");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        // Debug.Log("Entered a Trigger!!!");
        if(other.tag == "Package" && !PackagePicked){
            Debug.Log("Picked up the Package!!!!");
            PackagePicked = true;
            spriteRenderer.color = HasPackageColor;
            Destroy(other.gameObject, DestroyDelay);
            
        }
        if(other.tag == "DropLocation" && PackagePicked){
            Debug.Log("Dropped of our package!");
            PackagePicked = false;
            spriteRenderer.color = NoPackageColor;
        }
    }
}
