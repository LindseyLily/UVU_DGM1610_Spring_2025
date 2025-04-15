using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FPSNavMesh : MonoBehaviour
{
   public Transform[] points;
   private int destpoint = 0;
   private NavMeshAgent agent;

   void Start()
   {
      agent = GetComponent<NavMeshAgent>();
      //agent.autoBaking = false
      GotoNextPoint();
      agent.updateRotation = false;
   }

   void GotoNextPoint()
   {
      if (points.Length == 0)
         return;
      agent.destination = points[destpoint].position;
      destpoint = (destpoint + 1) % points.Length;
   }

   void Update()
   {
      if (!agent.pathPending && agent.remainingDistance < 0.5f)
         GotoNextPoint();
   }
}
