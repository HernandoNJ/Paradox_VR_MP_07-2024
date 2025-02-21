using Managers;
using UnityEngine;

namespace Others
{
    public class Final : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                UIManager.Instance.DeactivateHud();
                GameManager.Instance.locomotionSystem.SetActive(false);
                UIManager.Instance.ShowScreenFinal("HAS GANADO");
            }
        }
    }
}
