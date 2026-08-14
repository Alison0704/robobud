.PHONY: run test

make run:
	@echo "Running the application..."
	@dotnet run --project ConsoleApplicationPrototype/ConsoleApplicationPrototype.csproj
make test:
	@echo "Running tests..."
	@dotnet restore
	@dotnet build
	@dotnet test	