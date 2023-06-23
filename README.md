# SNS Customers Service

This repository contains the implementation of an AWS Simple Notification Service (SNS) based application that handles customer data. It is divided into four main components:

1. **Customers.Api**: This is the main API that handles customer related requests.

2. **Customers.Consumer**: This component consumes messages from the queue.

3. **SnsPublisher**: This component is responsible for publishing messages to the topic.

4. **SqsConsumer**: This component is responsible for consuming messages to the queue.

This project is an excellent example of a distributed system that uses AWS SNS for handling asynchronous messaging between components.
