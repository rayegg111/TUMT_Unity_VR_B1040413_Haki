using UnityEngine;
using UnityEngine.UI;

public class end : MonoBehaviour
{
    public Text say;
    private void Update()
    {
        if (TrashCount.LostTrash <= 0)
        {
            say.text = "作業到此為止，感謝您的遊玩與測試";
        }
        else
        {
            say.text = "請將周圍的垃圾丟入旁邊的垃圾桶 ---------------------------- >";
        }
    }
}
