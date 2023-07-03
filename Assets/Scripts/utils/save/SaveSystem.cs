namespace utils.save
{
    public interface SaveSystem
    {
        void Save(SaveData data);
        SaveData Load();
        void Clear();
    }
}