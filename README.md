# MvcDeserializationTest

Testing and Proof of Concept about MVC deserialization issues caused by a JSON object containing two properties with the same case-insensitive name.  

In this example, I'm showing that "orderId" and "orderID" break MVC's deserialization when trying to deserialize into a data model containing a property called "OrderId".  

https://mvcdeserializationtest.azurewebsites.net/
