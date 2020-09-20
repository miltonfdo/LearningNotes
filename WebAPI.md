
WebAPI

WebAPI is a framework which helps you to build/develop HTTP services.

Why select Web API?

    It is used to create simple, non-SOAP-based HTTP Services
    It is also an easy method for creation with Web API. With WCF REST Services
    It is based on HTTP and easy to define, expose and consume in a REST-ful way.
    It is lightweight architecture and ideal for devices that have limited bandwidth like

Is it right that ASP.NET Web API has replaced WCF?

    It's a not at all true that ASP.NET Web API has replaced WCF. In fact, it is another way of building non-SOAP based services, i.e., plain XML or JSON string.

Advantages of Web API are:
    - OData
    - Filters
    - Content Negotiation
    - Self-Hosting
    - Routing
    - Model Bindings

Web API controller action can return following values:
    - Void – It will return empty content
    - HttpResponseMessage - It will convert the response to an HTTP message.
    - IHttpActionResult - internally calls ExecuteAsync to create an HttpResponseMessage
    - Other types - You can write the serialized return value into the response body

Web API uses which of the following open-source library for JSON serialization?
    Web API uses Json.NET library for JSON serialization.

By default, Web API sends HTTP response with which of the following status code for all uncaught exception?
    500 - Internal Server Error