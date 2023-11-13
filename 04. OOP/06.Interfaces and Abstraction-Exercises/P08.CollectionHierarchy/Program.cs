using P08.CollectionHierarchy.Models;

AddCollection addCollection  = new AddCollection();
AddRemoveCollection  addRemoveCollection = new AddRemoveCollection();
MyList myList = new MyList();

string[] items = Console.ReadLine().Split();

Dictionary<string, List<int>> addedIndexes = new Dictionary<string, List<int>>
{
	{ "AddCollection", new List<int>() },
	{ "AddRemoveCollection", new List<int>() },
	{ "MyList", new List<int>() }
};
Dictionary<string, List<string>> removedItems = new Dictionary<string, List<string>>
{
	{ "AddRemoveCollection", new List<string>() },
	{ "MyList", new List<string>() }
};

foreach (var item in items)
{
	addedIndexes["AddCollection"].Add( addCollection.AddToCollection(item));
	addedIndexes["AddRemoveCollection"].Add(addRemoveCollection.AddToCollection(item));
	addedIndexes["MyList"].Add(myList.AddToCollection(item));

}
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
	removedItems["AddRemoveCollection"].Add(addRemoveCollection.Remove());
	removedItems["MyList"].Add(myList.Remove());
}

foreach (var kvp in addedIndexes)
{
	Console.WriteLine(string.Join(" ", kvp.Value));
}

foreach (var kv in removedItems)
{
	Console.WriteLine(string.Join(" ", kv.Value));
}
