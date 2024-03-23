var auth1 = Authenticator.Authenticator.GetInstance();
auth1.AddUser(1, "user1");
auth1.AddUser(2, "user2");
Console.WriteLine(auth1.GetUsers());

var auth2 = Authenticator.Authenticator.GetInstance();
auth1.AddUser(3, "user3");
Console.WriteLine(auth2.GetUsers());