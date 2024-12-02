using UnityEngine;
using UnityEngine.AI;

public class PlayerPathfinding : MonoBehaviour
{
    public Transform destination; // Punto de destino (se asigna en el editor)

    private NavMeshAgent agent; // Componente NavMeshAgent del Player

    void Start()
    {
        // Obtén el componente NavMeshAgent del Player
        agent = GetComponent<NavMeshAgent>();

        // Asigna el destino inicial si está configurado
        if (destination != null)
        {
            agent.SetDestination(destination.position);
        }
    }

    void Update()
    {
        // Si el destino está asignado, actualiza la posición hacia el destino
        if (destination != null)
        {
            agent.SetDestination(destination.position);
        }
    }
}
