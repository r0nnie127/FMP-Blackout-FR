using UnityEngine;

<<<<<<< HEAD
public class DrawerInteractable : MonoBehaviour, IInteractable
{ 
    public bool IsOpened { get; private set; }

    public string ChestID { get; private set; }

    public GameObject itemPrefab;

    public Sprite openedSprite;

    private void Start()
    {
        ChestID ??= GlobalHelper.GenerateUniqueID(gameObject);
    }

    public bool CanInteract()
    {
        return !IsOpened;
    }

    public void Interact()
    {
        if (!CanInteract()) return;

        OpenChest();

        Debug.Log("FWOOSH");
    }

    private void OpenChest()
    {
        SetOpened(true);

        if (itemPrefab)
        {
            GameObject droppedItem = Instantiate(itemPrefab, transform.position + Vector3.down, Quaternion.identity);
        }
    }

    public void SetOpened(bool opened)
    { 

        if (IsOpened = opened)
        {
            GetComponent<SpriteRenderer>().sprite = openedSprite;
        }
    }
=======
public class DrawerInteractable : MonoBehaviour { 


>>>>>>> c65cb53f63b3266af7de31203df37ca7ed6901d3
}
