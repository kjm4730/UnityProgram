using UnityEngine;
using UnityEngine.UI;

public class Reward : MonoBehaviour
{
    [SerializeField] int random;
    [SerializeField] Item [ ] dataList;

    [SerializeField] Image image;
    [SerializeField] Sprite sprite;
    private void Awake()
    {
        image = GetComponent<Image>();
    }

    void Start()
    {
        random = Random.Range(0, dataList.Length);

        gameObject.name = dataList[random].Name;
        image.sprite = sprite;
    }
}
