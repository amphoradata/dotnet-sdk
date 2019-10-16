#!/bin/bash

pushd generated
dotnet build
echo RUNNING TESTS
dotnet test
popd