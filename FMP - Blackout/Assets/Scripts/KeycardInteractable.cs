using UnityEngine;

public class KeycardInteractable : MonoBehaviour, IInteractable
{
    public bool CanInteract()
    {
        return true;
    }

    public void Interact()
    {
        Destroy(gameObject);
    }

  
}
