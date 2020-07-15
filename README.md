![Nuget Badge](https://img.shields.io/nuget/v/AmphoraData.Client)
[![Build Status](https://dev.azure.com/amphoradata/Public/_apis/build/status/amphoradata.dotnet-sdk?branchName=master)](https://dev.azure.com/amphoradata/Public/_build/latest?definitionId=8&branchName=master)

# Amphora Data DotNet SDK

A dotnet SDK for the Amphora platform.

## Installation

> AmphoraData.Client is a Net Standard 2.0 compatible library.

```
dotnet add package AmphoraData.Client
```

## Usage

Authenticate with your username and password

```cs
var authClient = new AuthenticationClient(httpClient); // choose your own HTTP client
var user = new LoginRequest
{
    Username = "YOUR USERNAME",
    Password = "YOUR PASSWORD"
};
var token = await authClient.RequestTokenAsync(user);
httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
```

## Open API

The code in `/client` was produced via [NSwag](https://github.com/RicoSuter/NSwag). View the OpenAPI document [here](https://app.amphoradata.com/swagger/)

## How to generate the client

Simply run [./generate.sh](./generate.sh) to generate the client. The generated code will be in [/client/AmphoraClient.cs](/client/AmphoraClient.cs)

> Update the version in [client.csproj](client/client.csproj) before publishing a nuget package.

## Sample

Check out the [sample here](sample/Program.cs).
