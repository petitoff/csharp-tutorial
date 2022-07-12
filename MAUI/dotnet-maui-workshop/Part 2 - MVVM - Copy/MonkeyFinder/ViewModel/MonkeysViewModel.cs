using MonkeyFinder.Services;

namespace MonkeyFinder.ViewModel;

public partial class MonkeysViewModel : BaseViewModel
{
    // model
    public ObservableCollection<Monkey> Monkeys { get; } = new();

    // service
    MonkeyService monkeyService;

    public MonkeysViewModel(MonkeyService monkeyService)
    {
        Title = "Monkey Finder";
        this.monkeyService = monkeyService;
    }

    async Task GetMonkeysAsync()
    {
        if(IsBusy)
        {
            return;
        }

        try
        {
            IsBusy = true;
            var monkeys = await monkeyService.GetMonkeys();

            if(Monkeys.Count != 0)
            {
                Monkeys.Clear();
            }

            foreach(var monkey in monkeys)
            {
                Monkeys.Add(monkey);
            }
        }
        catch
        {

        }
        finally
        {
            IsBusy = false;
        }
    }
}
