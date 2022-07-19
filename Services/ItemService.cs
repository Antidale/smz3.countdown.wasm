using smz3.countdown.wasm.Enums;
using smz3.countdown.wasm.Extenstions;

namespace smz3.countdown.wasm.Services
{
    public class ItemService
    {
        public HashSet<string> Items { get; set; } = new HashSet<string>();

        public ItemService()
        {
            var items = Enum.GetValues(typeof(Item));
            Items = ((Item[])items).Select(x => new { Name = x.GetDescription(), IsMajor = x.IsMajor() })
                                      .Where(x => x.IsMajor)
                                      .Select(x => x.Name)
                                      .ToHashSet();
        }

    }
}
