#!/bin/bash
echo "Generating dotnet code..."
rm client/AmphoraClient.cs
dotnet run --project generator
