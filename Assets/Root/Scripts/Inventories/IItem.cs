namespace Inventories
{
    public interface IItem
    {

        public ItemType ItemType { get; }


        public string Name { get; }

        public string Description { get; }
    }
}
