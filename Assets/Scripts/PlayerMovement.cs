using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float raycastDistance = 100f;

    private NavMeshAgent agent;
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Pointer.current != null && Pointer.current.press.wasPressedThisFrame)
        {
            HandleMovement();
        }
    }

    private void HandleMovement()
    {
        Vector2 screenPos = Pointer.current.position.ReadValue();

        Ray ray = Camera.main.ScreenPointToRay(screenPos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, raycastDistance, groundLayer))
        {
            agent.SetDestination(hit.point);
        }
        else
        {
            Debug.Log("No ground detected at the clicked position.");
        }
    }
}
