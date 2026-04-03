using System;

public class Entry
{
    private int _dateOfEntry;
    private string _entryDetails;
    private string _name;
    public Entry(int dateOfEntry, string entryDetails, string name)
    {
        _dateOfEntry = dateOfEntry;
        _entryDetails = entryDetails;
        _name = name;

    }
    public int GetDateOfEntry()
    {
        return _dateOfEntry;
    }
    public string GetEntryDetails()
    {
        return _entryDetails;
    }
    
}
