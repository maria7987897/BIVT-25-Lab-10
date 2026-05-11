namespace Lab10;

public interface IWhiteSerializer
{
    string Serialize<T>(T obj);
    T Deserialize<T>(string data);
}
