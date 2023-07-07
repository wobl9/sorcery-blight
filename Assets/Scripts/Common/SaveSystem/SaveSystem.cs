namespace utils.save
{
    public interface ISaveSystem
    {
        void Save(SaveData data);
        SaveData Load();
        void Clear();
    }
}