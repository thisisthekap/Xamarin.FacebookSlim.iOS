using ObjCRuntime;

namespace Xamarin.FacebookSlim.iOS
{
    [Native]
    public enum AppEventNameEnum : long
    {
        AchievedLevel = 0,
        AddedPaymentInfo = 1,
        AddedToCart = 2,
        AddedToWishlist = 3,
        CompletedRegistration = 4,
        CompletedTutorial = 5,
        InitiatedCheckout = 6,
        Purchased = 7,
        Rated = 8,
        Searched = 9,
        SpentCredits = 10,
        UnlockedAchievement = 11,
        ViewedContent = 12,
        Contact = 13,
        CustomizeProduct = 14,
        Donate = 15,
        FindLocation = 16,
        Schedule = 17,
        StartTrial = 18,
        SubmitApplication = 19,
        Subscribe = 20,
        AdImpression = 21,
        AdClick = 22
    }

    [Native]
    public enum LoggingBehaviorEnum : long
    {
        AccessTokens = 0,
        PerformanceCharacteristics = 1,
        AppEvents = 2,
        Informational = 3,
        CacheErrors = 4,
        UIControlErrors = 5,
        GraphAPIDebugWarning = 6,
        NetworkRequests = 7,
        DeveloperErrors = 8
    }

    [Native]
    public enum LoginResultEnum : long
    {
        Error = 0,
        Cancelled = 1,
        LoggedIn = 2
    }
}