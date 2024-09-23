namespace ShutgunGame.Classes
{

    public class Inventory
    {
        private List<string> items = new List<string>();

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public bool HasItem(string item)
    {
        return items.Contains(item);
    }
    public void removeItem(string item)
        {
           items.Remove(item);
        }
    }
}
