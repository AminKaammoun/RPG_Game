using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class saveSystem
{
    public static void SavePlayer(GameController player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.file";

        FileStream stream = new FileStream(path, FileMode.Create);

        playerData data = new playerData(player);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static playerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.file";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            playerData data = formatter.Deserialize(stream) as playerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save File not found in " + path);
            return null;
        }
    }

    public static void SaveGears(GameController player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/gears.file";

        FileStream stream = new FileStream(path, FileMode.Create);

        gearData data = new gearData(player);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static gearData LoadGears()
    {
        string path = Application.persistentDataPath + "/gears.file";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            gearData data = formatter.Deserialize(stream) as gearData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save File not found in " + path);
            return null;
        }
    }

    public static void SaveSwordGems(GameController player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/swordGems.file";

        FileStream stream = new FileStream(path, FileMode.Create);

        swordGemsData data = new swordGemsData(player);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static swordGemsData LoadSwordGems()
    {
        string path = Application.persistentDataPath + "/swordGems.file";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            swordGemsData data = formatter.Deserialize(stream) as swordGemsData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save File not found in " + path);
            return null;
        }
    }


    public static void SaveShieldGems(GameController player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/shieldGems.file";

        FileStream stream = new FileStream(path, FileMode.Create);

        shieldGemsData data = new shieldGemsData(player);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static shieldGemsData LoadShieldGems()
    {
        string path = Application.persistentDataPath + "/shieldGems.file";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            shieldGemsData data = formatter.Deserialize(stream) as shieldGemsData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save File not found in " + path);
            return null;
        }
    }

    public static void SaveHelmetGems(GameController player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/helmetGems.file";

        FileStream stream = new FileStream(path, FileMode.Create);

        helmetGemsData data = new helmetGemsData(player);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static helmetGemsData LoadHelmetGems()
    {
        string path = Application.persistentDataPath + "/helmetGems.file";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            helmetGemsData data = formatter.Deserialize(stream) as helmetGemsData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save File not found in " + path);
            return null;
        }
    }

    public static void SaveBeltGems(GameController player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/beltGems.file";

        FileStream stream = new FileStream(path, FileMode.Create);

        beltGemsData data = new beltGemsData(player);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static beltGemsData LoadBeltGems()
    {
        string path = Application.persistentDataPath + "/beltGems.file";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            beltGemsData data = formatter.Deserialize(stream) as beltGemsData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save File not found in " + path);
            return null;
        }
    }

    public static void SaveRingGems(GameController player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/ringGems.file";

        FileStream stream = new FileStream(path, FileMode.Create);

        ringGemsData data = new ringGemsData(player);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static ringGemsData LoadRingGems()
    {
        string path = Application.persistentDataPath + "/ringGems.file";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ringGemsData data = formatter.Deserialize(stream) as ringGemsData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save File not found in " + path);
            return null;
        }
    }
}
