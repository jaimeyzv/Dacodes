# Dacodes
First microservice which returns fruit array is CoinLion.Provider. Run it and use its URL in the 2nd microservice.
Second microservice which consumes the first microservice is CoinLion.Consumer. It consumes the endpoint [Consumes.API.URL]/api/fruit (GET) and do the logging using console log from Console APP.

No extra components needed. 
All dependencies already installed in each projects.
Clean architecture for both microservices.
CQRS implemented. 
SOLID principles.
RestSharp for consuming restful service 
