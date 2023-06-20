﻿using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using SqsPublisher;
using System.Text.Json;

var customer = new CustomerCreated
{
    Id = Guid.NewGuid(),
    Email = "leo@leoan.com",
    FullName = "Leonidas Antoniou",
    DateOfBirth = new DateTime(1996, 7, 27),
    GitHubUsername = "leo9806"
};

var snsClient = new AmazonSimpleNotificationServiceClient();

var topicArnResponse = await snsClient.FindTopicAsync("customers");

var publishRequest = new PublishRequest
{
    TopicArn = topicArnResponse.TopicArn,
    Message = JsonSerializer.Serialize(customer),
    MessageAttributes = new Dictionary<string, MessageAttributeValue>
    {
        {
            "MessageType", new MessageAttributeValue
            {
                DataType = "String",
                StringValue = nameof(CustomerCreated)
            }
        }
    }
};

var response = await snsClient.PublishAsync(publishRequest);