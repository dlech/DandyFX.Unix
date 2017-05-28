DandyFX.Unix
=============

This library provides managed wrappers of low-level unix functions.

It is similar to Mono.Unix, but targets netstandard2.0.

The idea here is to only provide what is actually needed rather than trying
to anticipate what *might* be needed.


Hacking
-------

    # Install dotnet 2.0 tooling
    # Fork the repo on GitHub
    git clone https://github.com/<user>/DandyFX.Unix
    cd DandyFX.Unix
    dotnet restore
    dotnet test test/
    git checkout -b my-feature
    # write a new test
    # implement the feature
    # write the documentation
    git add -i
    git commit
    git push
    # Send a pull request on GitHub
