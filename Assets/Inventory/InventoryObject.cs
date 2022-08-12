using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEditor;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObject : ScriptableObject, ISerializationCallbackReceiver
{

    public string savePath;
    public ItemDataBaseObject database;

    public List<InventorySlot> Container = new List<InventorySlot>();


    public void OnEnable()
    {

        load();
        database = Resources.Load<ItemDataBaseObject>("DataBase");
        save();
    }
    public void AddItem(ItemObject _item, int _amount)
    {

        for (int i = 0; i < Container.Count; i++)
        {
            if (Container[i].item == _item && (Container[i].item.type == ItemType.Potion || Container[i].item.type == ItemType.Materiel))
            {
                Container[i].AddAmount(_amount);
                return;
            }
          
        }

        Container.Add(new InventorySlot(database.GetId[_item], _item, _amount));
    }


    public void RemoveItem(ItemObject _item)
    {
        for (int i = 0; i < Container.Count; i++)
        {
            if (Container[i].item == _item)
            {
                Container[i].amount -= 1;
                if (Container[i].amount == 0)
                {

                    Container.Remove(Container[i]);

                    Inventory.refreshInv = true;
                    break;
                }
            }
        }

    }

    public void save()
    {
        string saveData = JsonUtility.ToJson(this, true);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(string.Concat(Application.persistentDataPath, savePath));
        bf.Serialize(file, saveData);
        file.Close();
    }
    public void load()
    {
        if (File.Exists(string.Concat(Application.persistentDataPath, savePath)))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(string.Concat(Application.persistentDataPath, savePath), FileMode.Open);
            JsonUtility.FromJsonOverwrite(bf.Deserialize(file).ToString(), this);
            file.Close();
        }
    }


    public void OnAfterDeserialize()
    {
        for (int i = 0; i < Container.Count; i++)
        {
            Container[i].item = database.GetItem[Container[i].ID];
        }
    }

    public void OnBeforeSerialize()
    {

    }
}
[System.Serializable]
public class InventorySlot
{
    public int ID;
    public ItemObject item;
    public int amount;
    public InventorySlot(int _id, ItemObject _item, int _amount)
    {
        ID = _id;
        item = _item;
        amount = _amount;
    }
    public void AddAmount(int value)
    {
        amount += value;
    }

}