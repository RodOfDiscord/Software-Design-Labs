using VideoProvider;

SubscriptionFactory managerCall = new ManagerCall();
Subscription sub1 = managerCall.CreateSubscription(300,TimeSpan.FromDays(31));
sub1.Activate();
SubscriptionFactory.PrintInfo(sub1);
Console.WriteLine("--------------------------");

SubscriptionFactory mobileApp = new MobileApp();
Subscription sub2 = mobileApp.CreateSubscription(200, TimeSpan.FromDays(24));
SubscriptionFactory.PrintInfo(sub2);
