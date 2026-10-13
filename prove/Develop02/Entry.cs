class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} | {_prompt}\n{_response}");
    }

    public string SaveOutput()
    {
        return $"{_date} | {_prompt} | {_response}";
    }
}