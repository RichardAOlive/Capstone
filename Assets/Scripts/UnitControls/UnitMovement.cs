using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitMovement : MonoBehaviour
{
    [SerializeField] private Animator unitAnimator = null;
    bool _isRunning;
    Camera myCam;
    NavMeshAgent myAgent;
    public LayerMask terrain;
    // Start is called before the first frame update
    void Start()
    {
        myCam = Camera.main;
        myAgent = GetComponent<NavMeshAgent>();
    }

    public void CmdSetRun(bool running)
    {
        _isRunning = running;
    }

    // Update is called once per frame
    void Update()
    {
        
        CmdSetRun(myAgent.velocity.magnitude > 0f);
        unitAnimator.SetBool("isRunning", _isRunning);

        if(Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = myCam.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, Mathf.Infinity, terrain))
            {
                myAgent.SetDestination(hit.point);
            }
        }
    }
}
