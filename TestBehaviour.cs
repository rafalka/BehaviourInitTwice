#if IOS
using PlatformView = UIKit.UIView;
#elif MACOS
using PlatformView = AppKit.NSView;
#elif ANDROID
using PlatformView = Android.Views.View;
#elif WINDOWS
using PlatformView = Microsoft.UI.Xaml.FrameworkElement;
#elif TIZEN
using PlatformView = Tizen.NUI.BaseComponents.View;
#elif NET6_0_OR_GREATER || (NETSTANDARD || !PLATFORM)
using PlatformView = System.Object;
#endif


namespace BehaviourInitTwice;

public class TestBehaviour : PlatformBehavior<VisualElement, PlatformView>
{
    protected override void OnAttachedTo(VisualElement bindable, PlatformView platformView)
    {
        Console.WriteLine($"==================================== OnAttachedTo({bindable.GetType().Name}, {platformView.GetType().Name}):\n{Environment.StackTrace}");
        base.OnAttachedTo(bindable, platformView);
    }

    protected override void OnDetachedFrom(VisualElement bindable, PlatformView platformView)
    {
        Console.WriteLine($"==================================== OnDetachedFrom({bindable.GetType().Name}, {platformView.GetType().Name}):\n{Environment.StackTrace}");
        base.OnDetachedFrom(bindable, platformView);
    }
}