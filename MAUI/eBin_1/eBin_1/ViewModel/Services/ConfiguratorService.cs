using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace eBin_1.ViewModel.Services;

public class ConfiguratorService
{
    public static async Task SaveData(Exports Data)
    {
        try
        {
            // convert object to json format
            var convert = Newtonsoft.Json.JsonConvert.SerializeObject(Data);

            // find path to special folder in android
            var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "configBin.json");

            // save to json file
            using var writer = File.CreateText(backingFile);
            await writer.WriteLineAsync(convert);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
    }

    public static async Task<Exports> LoadData()
    {
        try
        {
            // get file name
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "configBin.json");
            // read file
            string json = await File.ReadAllTextAsync(fileName);

            // deserialize/parse json
            var data = JsonConvert.DeserializeObject<Exports>(json);
            return data;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return null;
        }
    }
}
