using UnityEngine;
using UnityEngine.UI;

public class TrashCount : MonoBehaviour
{
    public Text trashcount;
    public static int LostTrash = 12;

    private void Update()
    {
        trashcount.text = "垃圾剩餘量：" + LostTrash;
    }
}
