using UnityEngine;
using UnityEngine.UI;

public class TrashCan : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "垃圾桶")
        {
            Destroy(gameObject);
            TrashCount.LostTrash -= 1;
        }
    }
}
