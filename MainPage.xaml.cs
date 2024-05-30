namespace BehaviourInitTwice;

public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private bool _added;
    private void OnAddBehaviourClicked(object sender, EventArgs e)
    {
        if (_added) return;
        _added = true;

        var testBehaviour = new TestBehaviour();
        StackLayout.Behaviors.Add(testBehaviour);
    }
}