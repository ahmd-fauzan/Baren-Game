using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
  NavMeshAgent agent;

  string status; //tahanan / main / base

  private void Start() {
    agent = GetComponent<NavMeshAgent>();
  }

    // Start is called before the first frame update
    public void Move(Vector3 point){
      agent.SetDestination(point);
    }
}
