using SingleResponsibility;

var note = new Note();
note.AddEntry("This is my first note.");
note.AddEntry("This is my second note.");

var persister = new NotePersister();
persister.Save(note);

var loadedNote = persister.Load();
loadedNote.AddEntry("This is my third note.");
persister.Save(loadedNote);

persister.Open();