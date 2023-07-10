
using Bridge_Design_Pattern;

Console.WriteLine("Hello, World!");

IMessageSender emailSender = new EmailSender();
IMessageSender msmqSender = new MSMQSender();
IMessageSender webSender = new WebServiceSender();

Message message = new SystemMessage();
message.Subject = "Test Message";
message.Body = "Hi, This is a Test Message";

message.MessageSender = emailSender;
message.Send();

message.MessageSender = webSender;
message.Send();

message.MessageSender = msmqSender;
message.Send();

UserMessage usermsg = new UserMessage();
usermsg.Subject = "Test Message";
usermsg.Body = "Hi, This is a Test Message";
usermsg.UserComments = "I hope you are well";

usermsg.MessageSender = emailSender;
usermsg.Send();

usermsg.MessageSender = webSender;
usermsg.Send();

usermsg.MessageSender = msmqSender;
usermsg.Send();