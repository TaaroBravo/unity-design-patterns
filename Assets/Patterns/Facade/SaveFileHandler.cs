using System.IO;
using UnityEngine;

namespace Patterns.Facade
{
    public static class SaveFileHandler
    {
        private static string GetPath() => Application.persistentDataPath + "/save.json";

        public static void SaveToDisk(SaveData data)
        {
            string json = JsonUtility.ToJson(data);
            File.WriteAllText(GetPath(), json);
        }

        public static SaveData LoadFromDisk()
        {
            string path = GetPath();
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                return JsonUtility.FromJson<SaveData>(json);
            }
            return null;
        }
    }
}