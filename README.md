# Singletone Design Pattern

The Singleton Design Pattern is a Creational Design Pattern used to ensure that a class has only one instance and provides a global point of access to it. In C#, the Singleton Design Pattern is useful when we need exactly one instance of a class to coordinate actions across the system. It is commonly used in scenarios where multiple objects need to access a single shared resource, such as configuration settings, access to a shared resource like a file system, or managing a connection to a database.

## Key Characteristics of the Singleton Design Pattern in C#

- `Single Instance:` This Design Pattern ensures that only one instance of the Singleton class is created throughout the application.
- `Global Access:` Provides a global access point to that instance.
- `Lazy Initialization:` We can lazily initialize the singleton instance, which means it is created when it is needed for the first time, not when the application starts.
- `Thread Safety:` When used in a multi-threaded application, the singleton needs to be thread-safe to prevent multiple instances from being created.

## The following are the guidelines to implement the Singleton Design Pattern in C#.

- `Private Parameterless Constructor:` We need to create a private and parameterless constructor. This is required because it will restrict the class from being instantiated from outside the class; it will only instantiate from within the class.
- `Sealed Class:` The Singleton class should be declared sealed to ensure it cannot be inherited.
- `Static Variable:` We need to create a private static variable that holds the single instance of the class.
- `Public Static Method or Property:` We also need to create a public static property or method that will return the singleton instance. This method or property first checks whether the singleton class instance has been created. If the singleton instance is created, it returns that instance; otherwise, it will create an instance and then return it. This static method or property provides the global point of access to the singleton instance and ensures that only one instance of the class is created.
