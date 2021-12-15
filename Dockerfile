#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["SudoguruMainBackend/SudoguruMainBackend.csproj", "SudoguruMainBackend/"]
COPY ["EFMyDBContext/EFMyDBContext.csproj", "EFMyDBContext/"]
COPY ["SudokuBoard/SudokuBoard.csproj", "SudokuBoard/"]
COPY ["DALSudoku/DALSudoku.csproj", "DALSudoku/"]
COPY ["IDAlSudoku/IDAlSudoku.csproj", "IDAlSudoku/"]
COPY ["ISudokuCheckAlgoritme/ISudokuCheckAlgoritme.csproj", "ISudokuCheckAlgoritme/"]
COPY ["FactoryAlgorithm/FactoryAlgorithm.csproj", "FactoryAlgorithm/"]
COPY ["AlgorithmCheckBoardTest/AlgorithmCheckBoardTest.csproj", "AlgorithmCheckBoardTest/"]
COPY ["SudokuControlAlgorithme/SudokuControlAlgorithme.csproj", "SudokuControlAlgorithme/"]
RUN dotnet restore "SudoguruMainBackend/SudoguruMainBackend.csproj"
COPY . .
WORKDIR "/src/SudoguruMainBackend"
RUN dotnet build "SudoguruMainBackend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SudoguruMainBackend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SudoguruMainBackend.dll"]