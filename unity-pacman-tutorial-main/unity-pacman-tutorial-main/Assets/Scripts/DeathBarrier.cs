using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class DeathBarrier : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            GameManagerMario.Instance.ResetLevel(3f);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }

}
