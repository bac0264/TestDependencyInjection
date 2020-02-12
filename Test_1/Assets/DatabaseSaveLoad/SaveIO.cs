using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveIO
{
    private static readonly string baseSavePath;
    static SaveIO()
    {
        baseSavePath = Application.persistentDataPath;
    }
    // Save Load of Reaward FREE
    public static void SaveData(DataHero data, string fileName)
    {
        FileReadWrite.WriteToBinaryFile(baseSavePath + "/" + fileName + ".dat", data);
    }
    public static DataHero LoadData(string fileName)
    {
        string filePath = baseSavePath + "/" + fileName + ".dat";
        if (System.IO.File.Exists(filePath))
        {
            return FileReadWrite.ReadFromBinaryFile<DataHero>(filePath);
        }
        return null;
    }
}

internal class FileReadWrite
{
    public static void WriteToBinaryFile<T>(string filePath, T objectToWrite)
    {
        using (Stream stream = File.Open(filePath, FileMode.Create))
        {
            var binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, objectToWrite);
        }
    }
    public static T ReadFromBinaryFile<T>(string filePath)
    {
        using (Stream stream = File.Open(filePath, FileMode.Open))
        {
            var binaryFormatter = new BinaryFormatter();
            return (T)binaryFormatter.Deserialize(stream);
        }
    }
}