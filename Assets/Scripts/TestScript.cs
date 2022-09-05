using UnityEngine;

public class TestScript : MonoBehaviour
{
    private void Awake()
    {
        int number = InstantiateNumber();

        GameObject temp = InstantiateTest(gameObject);

        GameObject tempMarble = Instantiate(gameObject);
    }

    private int InstantiateNumber()
    {
        return 10;
    }

    private GameObject InstantiateTest(GameObject go)
    {
        return new GameObject();
    }
}
