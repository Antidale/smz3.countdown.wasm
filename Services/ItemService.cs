using smz3.countdown.wasm.Enums;
using smz3.countdown.wasm.Extenstions;

namespace smz3.countdown.wasm.Services
{
    public class ItemService
    {
        public HashSet<string> AllItems { get; set; } = new HashSet<string>();
        public HashSet<string> MajorItems { get; set; } = new HashSet<string>();

        public ItemService()
        {
            var items = Enum.GetValues(typeof(Item));
            MajorItems = ((Item[])items).Select(x => new { Name = x.GetDescription(), IsMajor = x.IsMajor() })
                                      .Where(x => x.IsMajor)
                                      .Select(x => x.Name)
                                      .ToHashSet();

            AllItems = ((Item[])items).Select(x => x.GetDescription())
                                      .OrderBy(x => x)
                                      .ToHashSet();
        }
    }
}
