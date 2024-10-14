
namespace MB12.RecursionBeispiel
{
    public class RecursionSample
    {
        public RecursionSample()
        {
            List = new List<Datensatz>();

            List.Add(new Datensatz { Id = 1, Name = "A", ParentId = null });
            List.Add(new Datensatz { Id = 2, Name = "B", ParentId = 1 });
            List.Add(new Datensatz { Id = 3, Name = "C", ParentId = 1 });
            List.Add(new Datensatz { Id = 4, Name = "D", ParentId = 2 });
            List.Add(new Datensatz { Id = 5, Name = "E", ParentId = 2 });
            List.Add(new Datensatz { Id = 6, Name = "F", ParentId = 4 });
            List.Add(new Datensatz { Id = 7, Name = "G", ParentId = 4 });
            List.Add(new Datensatz { Id = 8, Name = "H", ParentId = 3 });
        }

        private List<Datensatz> List { get; set; }

        public void BuildTree()
        {
            PrintTree(List, null, 1);
        }

        private void PrintTree(List<Datensatz> list, int? parentId, int level)
        {
            // select * from list where ParentId = parentId
            var filteredList = list.Where(x => x.ParentId == parentId);


            foreach (var ds in filteredList)
            {
                Console.WriteLine("".PadRight(level) + "|-" + ds.Name);
                PrintTree(list, ds.Id, level + 1);
            }
        }
    }
}
