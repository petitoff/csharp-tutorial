namespace MonkeyFinder.Services;

public class MonkeyService
{
    List<Monkey> monkeyList = new();
    public async Task<List<Monkey>> GetMonkeys()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("monkeydata.json");
        using var reader = new StreamReader(stream);
        var contenst = await reader.ReadToEndAsync();

        monkeyList = JsonSerializer.Deserialize<List<Monkey>>(contenst);

        return monkeyList;
    }
}
