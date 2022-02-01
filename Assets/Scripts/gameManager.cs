using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Camera camera;
    Transform playerSelected;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, Mathf.Infinity)){
                if(hit.collider.CompareTag("Player")){
                  playerSelected = hit.transform;
                }

                if(hit.collider.CompareTag("Ground") && !hit.collider.CompareTag("Player") && playerSelected != null){
                    Player playerScript = playerSelected.GetComponent<Player>();
                    playerScript.Move(hit.point);
                    
                }
            }
        }
    }

    private void OnCollisionEnter(Collision other) {
      if(other.collider.tag("Enemy")){
        
      }
    }
}
