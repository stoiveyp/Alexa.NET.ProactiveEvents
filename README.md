# Alexa.NET.ProactiveEvents
Small library to help with the Alexa ProactiveEvents API

## Setup your skill to allow proactive events

You have to onboard your skill with the proactive events API

This is a specific process and so the best documentation is the [Amazon docs on the subject](https://developer.amazon.com/docs/smapi/proactive-events-api.html#onboard-smapi)

## Getting a token for Proactive Events

With the client ID and secret from your Amazon developer console

```csharp
var messaging = new AccessTokenClient(AccessTokenClient.ApiDomainBaseAddress);
var details = await messaging.Send("clientId","clientSecret");
var token = details.Token;
```

## Creating a new Event
There are several event types, each in their own namespace, the simplest example is one of a Weather Alert
```csharp
using Alexa.NET.ProactiveEvents.WeatherAlerts;
...
var eventToSend = new WeatherAlert(WeatherAlertType.Snowstorm);
```
### Localised Attributes
Some alerts have required fields which must be created with a string per locale for each you support. 
These are created as LocaleAttributes.
```csharp
var localeAttribute = new LocaleAttributes();
localeAttribute.Add("en-GB","GBLocale");
localeAttribute.Add("en-US","USLocale");
```
or if you're only in one locale
```csharp
var localeAttribute = new LocaleAttributes("en-GB","GBLocale");
var eventToSend = new WeatherAlert(WeatherAlertType.Tornado,localeAttribute);
```
## Creating a request to a single User ID
```csharp
var request = new Alexa.NET.ProactiveEvents.UserEventRequest("userId",eventToSend)
{
    ExpiryTime = DateTimeOffset.Now.AddMinutes(10),
    ReferenceId = Guid.NewGuid().ToString("N"),
    TimeStamp = DateTimeOffset.Now,
};
```
## Creating a request to all subscribed users
```csharp
var request = new BroadcastEventRequest(eventToSend)
{
    ExpiryTime = DateTimeOffset.Now.AddMinutes(10),
    ReferenceId = Guid.NewGuid().ToString("N"),
    TimeStamp = DateTimeOffset.Now,
};
```
## Sending a request
```csharp
var client = new ProactiveEventsClient(
ProactiveEventsClient.EuropeEndpoint, token ,true); 
// Change true to false for a live environment
await client.Send(request);
```


## Receiving events when a user changes their subscriptions

In the constructor of the function/API setup place the following code
```csharp
new ProactiveSubscriptionChangedRequestHandler().AddToRequestHandler();
```
and then you can check your request type
```csharp
if (input.Request is ProactiveSubscriptionChangedRequest request)
{
    var remainingEventTypes = request.Subscriptions;
}
```