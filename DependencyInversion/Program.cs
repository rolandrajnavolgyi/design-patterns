using DependencyInversion;

var storage = new Storage();
storage.AddItem("Adidas Xtreme", 42, 100);
storage.AddItem("Nike Runner", 43, 120);
storage.AddItem("Rieker Silent", 42, 110);

var inventory = new Inventory(storage);
inventory.PrintItemSizeCount(42);
