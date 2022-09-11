using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class fishingShop : MonoBehaviour
{
    public InventoryObject inventory;
    public int Xstart;
    public int Ystart;
    public float XspaceBtwItem;
    public int NumberOfColumns;
    public float YspaceBtwItems;
    Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();
    public static bool refreshInv;

    // Start is called before the first frame update
    void Start()
    {
        CreateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        if (refreshInv)
        {

            itemsDisplayed.Clear();
            GameObject[] fishs = GameObject.FindGameObjectsWithTag("fishIcons");

            foreach (GameObject fish in fishs)
            {
                Destroy(fish);
            }

            CreateDisplay();
            refreshInv = false;

        }
    }

   public void CreateDisplay()
    {

        for (int i = 0; i < inventory.Container.Count; i++)
        {

            var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
            obj.transform.SetParent(GameObject.FindGameObjectWithTag("fishRightSide").transform, false);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            obj.GetComponentInChildren<TextMeshProUGUI>().text = "X" + inventory.Container[i].amount.ToString("n0");
            itemsDisplayed.Add(inventory.Container[i], obj);

        }
    }

    public Vector3 GetPosition(int i)
    {
        return new Vector3(Xstart + (XspaceBtwItem * (i % NumberOfColumns)), Ystart + (-YspaceBtwItems * (i / NumberOfColumns)), 0f);
    }
}
