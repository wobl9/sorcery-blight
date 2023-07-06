using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace utils.save
{
    public class BinarySaveSystem : ISaveSystem
    {
        private string _filePath;

        public BinarySaveSystem()
        {
            _filePath = Application.persistentDataPath + "/Save.dat";
        }

        public void Save(SaveData data)
        {
            using (var file = File.Create(_filePath))
            {
                new BinaryFormatter().Serialize(file, data);
            }
        }

        public SaveData Load()
        {
            try
            {
                SaveData saveData;
                using (var file = File.Open(_filePath, FileMode.Open))
                {
                    var loadedData = new BinaryFormatter().Deserialize(file);
                    saveData = (SaveData)loadedData;
                }

                return saveData;
            }
            catch
            {
                return null;
            }
        }

        public void Clear()
        {
            try
            {
                File.Delete(_filePath);
            }
            catch
            {
                Debug.Log("can't clear save system");
            }
        }
    }
}